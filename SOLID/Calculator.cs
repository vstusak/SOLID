using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Calculator: IOperator
    {
        public IOperator _operator;

        public Calculator(IOperator @operator)
        {
            _operator = @operator;
        }

        public double Calculate(double number1, double number2)
        {
            return _operator.Calculate(number1, number2);
        }
    }
}
