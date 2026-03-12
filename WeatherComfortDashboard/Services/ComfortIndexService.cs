namespace WeatherComfortDashboard.Services
{
    public class ComfortIndexService
    {
        public double Calculate(double temp, int humidity, double wind, int clouds)
        {
            double tempPenalty = Math.Abs(temp - 24) * 2.5;
            double humidityPenalty = Math.Abs(humidity - 50) * 0.4;
            double windPenalty = Math.Abs(wind - 4) * 2;
            double cloudPenalty = clouds * 0.1;

            double score = 100 - (tempPenalty + humidityPenalty + windPenalty + cloudPenalty);

            return Math.Max(0, Math.Min(100, score));
        }
    }
}