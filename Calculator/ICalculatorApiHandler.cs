using Calculator.Contracts;

namespace Calculator;

public interface ICalculatorApiHandler
{
    double Execute(InputData input);
}