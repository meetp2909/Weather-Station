using weathersystemlibrary.Interface;
namespace weathersystemlibrary
{
    // Defined  a class named StatisticsDisplay which implements the IDisplay interface.
    public class StatisticsDisplay : IDisplay
    {
        // Private field to hold WeatherData instance.
        private WeatherData weatherData;

        // Constructor for StatisticsDisplay class, taking a WeatherData object as a parameter.
        public StatisticsDisplay(WeatherData weatherData)
        {
            // Assigning the passed WeatherData object to the private field.
            this.weatherData = weatherData;
            // Subscribe to weatherData's events (this is a placeholder comment, actual subscription code may be missing).
        }

        // Implementation of the Display method required by the IDisplay interface.
        public void Display()
        {
            // Retrieve temperature history from WeatherData object.
            int[] temperatures = weatherData.GetTemperatureHistory();

            // Check if temperature history is empty.
            if (temperatures.Length == 0)
            {
                // Display message indicating no weather data available.
                Console.WriteLine("No weather data available for statistics.");
                return;
            }

            // Initialize variables for calculating statistics.
            int totalTemperature = 0;
            int maxTemperature = int.MinValue;
            int minTemperature = int.MaxValue;

            // Iterate through temperature history to calculate total, max, and min temperatures.
            foreach (int temperature in temperatures)
            {
                totalTemperature += temperature;
                maxTemperature = Math.Max(maxTemperature, temperature);
                minTemperature = Math.Min(minTemperature, temperature);
            }

            // Calculate average temperature.
            double averageTemperature = (double)totalTemperature / temperatures.Length;

            // It will display weather statistics.
            Console.WriteLine("Weather Statistics:");
            Console.WriteLine($"Average Temperature: {averageTemperature:F1}°C");
            Console.WriteLine($"Max Temperature: {maxTemperature}°C");
            Console.WriteLine($"Min Temperature: {minTemperature}°C");
            Console.WriteLine();
        }
    }
}
