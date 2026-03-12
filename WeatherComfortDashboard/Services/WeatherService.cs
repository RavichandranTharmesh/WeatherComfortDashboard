using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;
using WeatherComfortDashboard.Models;

namespace WeatherComfortDashboard.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly IMemoryCache _cache;

        public WeatherService(
            HttpClient httpClient,
            IConfiguration configuration,
            IMemoryCache cache)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _cache = cache;
        }

        public async Task<WeatherResult> GetWeatherAsync(int cityId)
        {
            string cacheKey = $"weather_{cityId}";

            if (_cache.TryGetValue(cacheKey, out WeatherResult cachedWeather))
            {
                Console.WriteLine($"CACHE HIT for city {cityId}");
                return cachedWeather;
            }

            Console.WriteLine($"API CALL for city {cityId}");

            var apiKey = _configuration["OpenWeather:ApiKey"];

            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new Exception("OpenWeather API key is missing in appsettings.json");
            }

            var url = $"https://api.openweathermap.org/data/2.5/weather?id={cityId}&units=metric&appid={apiKey}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonDocument.Parse(json);

            var weather = new WeatherResult
            {
                CityName = data.RootElement.GetProperty("name").GetString(),
                Description = data.RootElement.GetProperty("weather")[0].GetProperty("description").GetString(),
                Temperature = data.RootElement.GetProperty("main").GetProperty("temp").GetDouble(),
                Humidity = data.RootElement.GetProperty("main").GetProperty("humidity").GetInt32(),
                WindSpeed = data.RootElement.GetProperty("wind").GetProperty("speed").GetDouble(),
                Cloudiness = data.RootElement.GetProperty("clouds").GetProperty("all").GetInt32()
            };

            _cache.Set(cacheKey, weather, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });

            Console.WriteLine($"CACHED city {cityId} for 5 minutes");

            return weather;
        }
    }
}