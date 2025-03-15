using WeatherAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace WeatherAPI.Services
{
    public class WeatherService
    {
        private static readonly List<Weather> weatherData = new List<Weather>
        {
            new Weather { City = "Karachi", Temperature = 32.0.ToString(), Condition = "Sunny" },
            new Weather { City = "Lahore", Temperature = 30.5.ToString(), Condition = "Partly Cloudy" },
            new Weather { City = "Islamabad", Temperature = 28.3.ToString(), Condition = "Cloudy" },
            new Weather { City = "Chakwal", Temperature = 26.1.ToString(), Condition = "Rainy" },
            new Weather { City = "Faisalabad", Temperature = 31.4.ToString(), Condition = "Humid" },
            new Weather { City = "Narowal", Temperature = 27.9.ToString(), Condition = "Thunderstorms" }
        };

        public List<Weather> GetAllWeather()
        {
            return weatherData;
        }

        public Weather? GetWeatherByCity(string city)
        {
            return weatherData.FirstOrDefault(w => w.City.ToLower() == city.ToLower());
        }
    }
}
