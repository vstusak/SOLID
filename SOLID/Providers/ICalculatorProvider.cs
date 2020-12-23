using SOLID.Models;
using SOLID.Strategies;

namespace SOLID
{
    public interface ICalculatorProvider
    {
        void SetStrategy(ICalculationStrategy strategy);
        int Calculate(Input input);
    }
}