using SOLID.Models;

namespace SOLID.Factories
{
    public interface ICalculationStrategyFactory
    {
        void Set(Operand operand);
    }
}