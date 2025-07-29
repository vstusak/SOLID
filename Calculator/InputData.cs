using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InputData
    {
        public InputData(double value1, double value2, OperationEnum operation)
        {
            Value1 = value1;
            Value2 = value2;
            Operator = operation;
        }
        public OperationEnum Operator; 
        public double Value1;
        public double Value2;
    }
}
