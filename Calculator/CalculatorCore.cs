using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorCore : ICalculatorCore
    {
        public double Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public double Sub(int value1, int value2)
        {
            return value1 - value2;
        }

        public double Mult(int value1, int value2)
        {
          return   value1 * value2;
        }

        public double Div(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException($"You are trying divide {value1} by 0.");
            }

            return value1 / value2;
        }
    }
    public interface ICalculatorCore
    {
        double Add(int value1, int value2);
        double Sub(int value1, int value2);
        double Mult(int value1, int value2);
        double Div(double value1, double value2);
    }
}
