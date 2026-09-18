using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarden.WebApi.Controllers.v1
{
    //NOTE:Control name of endpoint, class name (also for different namespaces) and route for different versions of API
    [ApiController]
    [Route("/api/v1/WeatherForecast")]
    public class WeatherForecastV1Controller : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecastV1")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
