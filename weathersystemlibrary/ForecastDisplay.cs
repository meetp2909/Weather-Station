namespace weathersystemlibrary
{

    // Defined class which implement interface and show weather forecast information  
    public class ForecastDisplay : IDisplay
    {
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

//  Execution of this method display weather forecast
        public void Display()
        {
            Console.WriteLine("Weather Forecast:");
            Console.WriteLine("Sunny with a chance of clouds");
            Console.WriteLine();
        }
    }
}