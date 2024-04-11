using weathersystemlibrary.Interface;
namespace weather_app
{
//  Define class with name of file
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            // Creating display objects
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions");
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("Statistics");
            IDisplay forecastDisplay = weatherStation.CreateDisplay("Forecast");

            // Update weather data numerous time 
            for (int i = 0; i < 10; i++)
            {
                WeatherData.Instance.UpdateWeatherData();
            }

            // Display weather data
            currentConditionsDisplay.Display();
            statisticsDisplay.Display();
            forecastDisplay.Display();
        }
    }
}