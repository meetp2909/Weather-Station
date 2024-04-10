namespace weather_app
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            // Create display objects
            IDisplay CurrentConditionsDisplay = WeatherStation.CreateDisplay("CurrentConditions");
            IDisplay StatisticsDisplay = WeatherStation.CreateDisplay("Statistics");
            IDisplay ForecastDisplay = WeatherStation.CreateDisplay("Forecast");

            // Update weather data multiple times to generate temperature history
            for (int i = 0; i < 10; i++)
            {
                WeatherData.Instance.UpdateWeatherData();
            }

            // Display weather data
            CurrentConditionsDisplay.Display();
            StatisticsDisplay.Display();
            ForecastDisplay.Display();
        }
    }
}