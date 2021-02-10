namespace SOLID.Interfaces
{
    public class ICalculators
    {
        public interface ICalculator
        {
            public int ReadNumbers();

            public char ReadOperation();

            public int PerformCalculation();

            public void PrintResult();
        }
    }
}