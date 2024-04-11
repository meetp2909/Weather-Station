namespace weathersystemlibrary
{
    // Defined the WeatherStation class responsible for creating display objects.
    public class WeatherStation
    {
        // Method to create display objects based on the provided display type.
        public IDisplay CreateDisplay(string displayType)
        {
            // Retrieve the singleton instance of WeatherData.
            WeatherData weatherData = WeatherData.Instance;

            // Switch statement to handle different display types.
            switch (displayType)
            {
                // If the display type is "CurrentConditions", create a new CurrentConditionsDisplay object.
                case "CurrentConditions":
                    return new CurrentConditionsDisplay(weatherData);
                // If the display type is "Statistics", create a new StatisticsDisplay object.
                case "Statistics":
                    return new StatisticsDisplay(weatherData);
                // If the display type is "Forecast", create a new ForecastDisplay object.
                case "Forecast":
                    return new ForecastDisplay(weatherData);
                // If the display type is not recognized, throw an ArgumentException.
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}
