namespace SOLID.Calculations;

public class CalculatorMethodSub : ICalculatorMethod
{
    public string Process(int value1, int value2)
    {
        var result = value1 - value2;
        var resultMessage = $"\n{value1} - {value2} = {result}";
        return resultMessage;
    }
}