
namespace weathersystemlibrary
{
    public class WeatherStation
    {
        public IDisplay CreateDisplay(string displayType)
        {
            WeatherData weatherData = WeatherData.Instance;

            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditionsDisplay(weatherData);
                case "Statistics":
                    return new StatisticsDisplay(weatherData);
                case "Forecast":
                    return new ForecastDisplay(weatherData);
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}