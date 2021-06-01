using Lesson1_SRP.Entities;

namespace Lesson1_SRP
{
    public interface IRetirementCalculator
    {
        int Calculate(IPerson person);
    }
}