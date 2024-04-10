namespace weathersystemlibrary
{
    public class ForecastDisplay : IDisplay
    {
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to weatherData's events
        }

        public void Display()
        {
            Console.WriteLine("Weather Forecast:");
            // Implement logic to generate and display weather forecast
            Console.WriteLine("Sunny with a chance of clouds");
            Console.WriteLine();
        }
    }
}