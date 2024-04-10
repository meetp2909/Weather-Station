namespace weathersystemlibrary
{
    public class CurrentConditionsDisplay : IDisplay
    {
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }
        public void Display()
        {
            Console.WriteLine("Current Weather Conditions:");
            Console.WriteLine($"Temperature: {weatherData.Temperature}°C");
            Console.WriteLine($"Humidity: {weatherData.Humidity}%");
            Console.WriteLine($"Wind Speed: {weatherData.WindSpeed} km/h");
            Console.WriteLine();
        }
    }
}