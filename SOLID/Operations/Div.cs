using SOLID.Exceptions;

namespace SOLID
{
    partial class Program
    {
        public class Div : IOperation
        {
            private readonly int _a;
            private readonly int _b;

            /// <summary>
            /// Divides a by b when executed
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            public Div(int a, int b)
            {
                _a = a;
                _b = b;
            }

            public int Execute()
            {
                if (_b == 0)
                {
                    throw new CalculatorInputException("Cannot divide by zero");
                }
                return _a / _b;
            }
        }

    }
}
