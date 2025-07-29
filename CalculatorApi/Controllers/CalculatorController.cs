using Calculator;
using Microsoft.AspNetCore.Mvc;
namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController: ControllerBase
{
    private readonly ICalculatorApiHandler _calculatorApiHandler;
    private readonly ILogger<CalculatorController> _logger;
    public CalculatorController(ICalculatorApiHandler calculatorApiHandler, ILogger<CalculatorController> logger)
    {
        _calculatorApiHandler = calculatorApiHandler;
        _logger = logger;
    }

    [HttpPost]
    public double Post(InputData inputData)
    {
        var result = _calculatorApiHandler.Execute(inputData);
        return result;
    }
}