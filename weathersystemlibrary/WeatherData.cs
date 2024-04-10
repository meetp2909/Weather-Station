namespace weathersystemlibrary
{
    public class WeatherData
    {
        private static WeatherData? instance;
        private Random random;
        private List<int> temperatureHistory;

        private WeatherData()
        {
            random = new Random();
            temperatureHistory = new List<int>();
        }

        public static WeatherData Instance
        {
            get
            {
                if (instance == null)
                    instance = new WeatherData();
                return instance;
            }
        }

        // Properties to hold weather data (temperature, humidity, wind speed, etc.)
        public int Temperature { get; private set; }
        public int Humidity { get; private set; }
        public int WindSpeed { get; private set; }

        // Method to update weather data and notify observers
        public void UpdateWeatherData()
        {
            // Generate random values for temperature, humidity, and wind speed
            Temperature = random.Next(-20, 40); // Random temperature between -20°C and 40°C
            Humidity = random.Next(0, 101); // Random humidity between 0% and 100%
            WindSpeed = random.Next(0, 101); // Random wind speed between 0 km/h and 100 km/h

            // Add current temperature to history
            temperatureHistory.Add(Temperature);

            // Notify observers (display objects) about the weather data change
            NotifyObservers();
        }

        // Method to retrieve temperature history
        public int[] GetTemperatureHistory()
        {
            return temperatureHistory.ToArray();
        }

        // Method to notify observers
        private void NotifyObservers()
        {
            // Implementation to notify observers
        }
    }
}