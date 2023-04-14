namespace SOLID;

public class Calculator
{
    private readonly ICalculatorMethod _calculatorMethod;

    public Calculator(ICalculatorMethod calculatorMethod)
    {
        _calculatorMethod = calculatorMethod;
    }

    public string Calculate(int value1, int value2)
    {
        var result = _calculatorMethod.Process(value1, value2).ToString();
        return result;

    }
}