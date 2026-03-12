namespace WeatherComfortDashboard.Models
{
    public class ComfortResult
    {
        public string CityName { get; set; }
        public string WeatherDescription { get; set; }
        public double Temperature { get; set; }
        public double ComfortScore { get; set; }
        public int Rank { get; set; }
    }
}

