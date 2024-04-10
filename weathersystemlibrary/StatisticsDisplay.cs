
namespace weathersystemlibrary
{
    public class StatisticsDisplay : IDisplay
    {
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            // Subscribe to weatherData's events
        }

        public void Display()
        {
            int[] temperatures = weatherData.GetTemperatureHistory();

            if (temperatures.Length == 0)
            {
                Console.WriteLine("No weather data available for statistics.");
                return;
            }

            // Calculate statistics
            int totalTemperature = 0;
            int maxTemperature = int.MinValue;
            int minTemperature = int.MaxValue;

            foreach (int temperature in temperatures)
            {
                totalTemperature += temperature;
                maxTemperature = Math.Max(maxTemperature, temperature);
                minTemperature = Math.Min(minTemperature, temperature);
            }

            double averageTemperature = (double)totalTemperature / temperatures.Length;

            // Display statistics
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Average Temperature: {averageTemperature:F1}°C");
            Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            Console.WriteLine($"Min Temperature: {minTemperature}°C");
            Console.WriteLine();

        }
    }
}