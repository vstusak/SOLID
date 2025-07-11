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

        [HttpGet]
        //[HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {

            return 3;
        }

        [HttpPost]
        //[HttpGet(Name = "GetWeatherForecast2")]
        public int TwoGet( int abc) // bere hodnotu z Body
        {

            return abc;
        }
    }

    //TODO: use TDD where is possible
    //TODO: create data class with values and operator
    //TODO: create POST - send value1, value2 and operator (instance data class)
    //TODO: create CalculatorAPIHandler
    //TODO: compare CalculatorHandler and CalculatorAPIHandler and refactor them
    //TODO: clean up weather forecast everywhere
}
