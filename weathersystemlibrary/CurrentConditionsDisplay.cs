namespace weathersystemlibrary
{

    //  Defined class with the name of file which implement the interface IDisplay
    public class CurrentConditionsDisplay : IDisplay
    {
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        // Executing method to show temp, humidity, wind 
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