namespace SOLID;

public class Calculator
{
    private readonly ICalculatorMethod _calculatorMethod;
    private readonly int _value1;
    private readonly int _value2;
    public Calculator(int value1, int value2, ICalculatorMethod calculatorMethod)
    {
        _calculatorMethod = calculatorMethod;
        _value1 = value1;
        _value2 = value2;
    }

    public string Calculate()
    {
        var result = _calculatorMethod.Process(_value1, _value2).ToString();
        return result;

    }
}