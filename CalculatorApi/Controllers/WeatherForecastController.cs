using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public int Get(int abc)
        //{

        //    return abc;
        //}

        [HttpGet(Name = "GetWeatherForecast2")]
        public int TwoGet([FromBody]int abc) // bere hodnotu z Body
        {

            return abc;
        }
    }

    // TODO: add POST method
}
