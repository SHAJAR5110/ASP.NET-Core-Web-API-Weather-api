using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Models;
using WeatherAPI.Services;
using System.Collections.Generic;

namespace WeatherAPI.Controllers
{
    [Route("weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService = new WeatherService();

        [HttpGet]
        public ActionResult<List<Weather>> GetAll()
        {
            return Ok(_weatherService.GetAllWeather());
        }

        [HttpGet("{city}")]
        public ActionResult<Weather> GetByCity(string city)
        {
            var weather = _weatherService.GetWeatherByCity(city);

            if (weather == null)
            {
                return NotFound(new { Message = "No city found!" });
            }

            return Ok(weather);
        }
    }
}
