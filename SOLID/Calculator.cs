using System.Collections.Generic;

namespace SOLID
{
    public class Calculator
    {
        private readonly Dictionary<string, IOperation> _operations;

        public Calculator()
        {
            _operations = new Dictionary<string, IOperation>
        {
            { "+", new Addition() },
            { "-", new Subtraction() },
            { "*", new Multiplication() },
            { "/", new Division() }
        };
        }

        public double Calculate(double a, string operation, double b)
        {
            return _operations[operation].Execute(a, b);
        }
    }
}
