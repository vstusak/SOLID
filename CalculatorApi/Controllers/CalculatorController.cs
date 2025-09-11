using Calculator;
using Microsoft.AspNetCore.Mvc;
namespace CalculatorApi.Controllers;

//TODO: Run from Swagger - resolve exception!
/// <summary>
/// Controller - conventional naming for api controller.
/// Provides control for one url = "endpoint".
/// Can have more types methods - get, post, put, fetch..
/// or more methods of the same type (e.g. Get with various parameters or body data.)
/// </summary>
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