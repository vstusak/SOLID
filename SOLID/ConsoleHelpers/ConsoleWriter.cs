using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class ConsoleWriter
    {
        public OperatorHelpers _operatorSelector;

        public ConsoleWriter()
        {
            _operatorSelector = new OperatorHelpers();
        }

        public void SetValidOperator()
        {
            Console.WriteLine("\nSet valid operator (+, -, *, /)");
        }

        public void SetValue(string NumberOrder)
        {
            Console.WriteLine($"\nSet {NumberOrder} value");
        }

        public void ShowResult(double number1, double number2, double result, IOperator @operator)
        {
            var selectedOperator = _operatorSelector.SelectRightOperatorForWriter(@operator);
            Console.WriteLine($"\n{number1} {selectedOperator} {number2} = {result}");
        }
    }
}
