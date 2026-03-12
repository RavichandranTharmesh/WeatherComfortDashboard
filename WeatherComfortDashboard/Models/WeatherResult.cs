namespace WeatherComfortDashboard.Models
{
    public class WeatherResult
    {
        public string CityName { get; set; }
        public string Description { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public int Cloudiness { get; set; }
    }
}
