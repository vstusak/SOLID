namespace SOLID.Interfaces
{
    public class IOperations
    {
        public int Result;

        public interface IOperation
        {
            public int CalculateResult();
        }
    }
}