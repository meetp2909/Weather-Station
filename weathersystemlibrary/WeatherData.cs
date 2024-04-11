namespace weathersystemlibrary
{
    // Defined the WeatherData class responsible for managing weather data.
    public class WeatherData
    {
        // Defined a private static nullable instance variable.
        private static WeatherData? instance;
        // Defined a private Random object for generating random values.
        private Random random;
        // Defined a private List<int> to store temperature history.
        private List<int> temperatureHistory;

        // Private constructor to initialize the random object and temperature history list.
        private WeatherData()
        {
            // Instantiation of a new Random object.
            random = new Random();
            // Instantiation of a new List<int> for temperature history.
            temperatureHistory = new List<int>();
        }

        // Public static property to access the singleton instance of WeatherData.
        public static WeatherData Instance
        {
            // Getter for the instance property.
            get
            {
                // If the instance is null, create a new WeatherData instance.
                if (instance == null)
                    instance = new WeatherData();
                // Return the instance.
                return instance;
            }
        }

        // Public property to hold the current temperature.
        public int Temperature { get; private set; }
        // Public property to hold the current humidity.
        public int Humidity { get; private set; }
        // Public property to hold the current wind speed.
        public int WindSpeed { get; private set; }

        // Method to update weather data and notify observers.
        public void UpdateWeatherData()
        {
            // Generate random values for temperature, humidity, and wind speed.
            Temperature = random.Next(-20, 40); // Random temperature between -20°C and 40°C.
            Humidity = random.Next(0, 101); // Random humidity between 0% and 100%.
            WindSpeed = random.Next(0, 101); // Random wind speed between 0 km/h and 100 km/h.
            // Add the current temperature to the temperature history list.
            temperatureHistory.Add(Temperature);

            // Notify observers about the updated weather data.
            NotifyObservers();
        }

        // Method to retrieve temperature history.
        public int[] GetTemperatureHistory()
        {
            // Convert the temperature history list to an array and return it.
            return temperatureHistory.ToArray();
        }

        // Private method to notify observers about the updated weather data.
        private void NotifyObservers()
        {
            // Implementation to notify observers (actual implementation is missing here).
        }
    }
}
