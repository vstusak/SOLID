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
    //TODO: CalculatorCore.ProcessInput not tested (logic currently  in CalculatorHandlerTests)
    //TODO: clean up weather forecast everywhere
    //TODO: refactor to use description to enum. (use operator)
}
