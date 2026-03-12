using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeatherComfortDashboard.Models;
using WeatherComfortDashboard.Services;

namespace WeatherComfortDashboard.Controllers
{
    [Authorize]
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;
        private readonly ComfortIndexService _comfortIndexService;
        private readonly IWebHostEnvironment _environment;

        public WeatherController(
            WeatherService weatherService,
            ComfortIndexService comfortIndexService,
            IWebHostEnvironment environment)
        {
            _weatherService = weatherService;
            _comfortIndexService = comfortIndexService;
            _environment = environment;
        }

            public async Task<IActionResult> Dashboard()
        {
            var allowedUsers = new List<string>
    {
        "careers@fidenz.com"
    };

            var userEmail =
                User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value
                ?? User.Claims.FirstOrDefault(c => c.Type == "email")?.Value
                ?? User.Identity?.Name;

            if (string.IsNullOrEmpty(userEmail))
            {
                return Content("Logged in user email claim not found.");
            }

            if (!allowedUsers.Contains(userEmail.ToLower()))
            {
                return Content("Access denied. You are not an authorized user.");
            }

            var filePath = Path.Combine(_environment.ContentRootPath, "Data", "cities.json");

            if (!System.IO.File.Exists(filePath))
            {
                return Content("cities.json file not found.");
            }

            var json = await System.IO.File.ReadAllTextAsync(filePath);
            var cities = JsonSerializer.Deserialize<List<City>>(json);

            if (cities == null || !cities.Any())
            {
                return Content("No cities found in cities.json.");
            }

            var results = new List<ComfortResult>();

            foreach (var city in cities)
            {
                try
                {
                    var weather = await _weatherService.GetWeatherAsync(city.CityCode);

                    var comfortScore = _comfortIndexService.Calculate(
                        weather.Temperature,
                        weather.Humidity,
                        weather.WindSpeed,
                        weather.Cloudiness
                    );

                    results.Add(new ComfortResult
                    {
                        CityName = weather.CityName,
                        WeatherDescription = weather.Description,
                        Temperature = weather.Temperature,
                        ComfortScore = Math.Round(comfortScore, 2)
                    });
                }
                catch
                {
                    continue;
                }
            }

            var rankedResults = results
                .OrderByDescending(x => x.ComfortScore)
                .ToList();

            for (int i = 0; i < rankedResults.Count; i++)
            {
                rankedResults[i].Rank = i + 1;
            }

            return View(rankedResults);
        }

        [HttpGet]
        public IActionResult CacheInfo()
        {
            return Content("Weather data is cached for 5 minutes in IMemoryCache.");
        }
    }
}