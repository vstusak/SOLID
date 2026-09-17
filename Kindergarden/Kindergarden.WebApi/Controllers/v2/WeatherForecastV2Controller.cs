using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Kindergarden.WebApi.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("/api/v{version:apiVersion}/weather")]
    public class WeatherForecastV2Controller : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing2", "Bracing2", "Chilly2", "Cool2", "Mild2", "Warm2", "Balmy2", "Hot2", "Sweltering2", "Scorching2"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
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
