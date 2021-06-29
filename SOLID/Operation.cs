using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Operation : IOperation
    {
        public string Add(InputModel inputModel)
        {
            return Convert.ToString(inputModel.Input1 + inputModel.Input2);
        }
        public string Sub(InputModel inputModel)
        {
            return Convert.ToString(inputModel.Input1 - inputModel.Input2);
        }

        public string Div(InputModel inputModel)
        {
            if(inputModel.Input2 == 0)
            {
                throw new DivideByZeroException("Division by zero occured.");
            }
            
            return Convert.ToString(inputModel.Input1 / inputModel.Input2);        
        }

        public string Mul(InputModel inputModel)
        {
            return Convert.ToString(inputModel.Input1 * inputModel.Input2);
        }     
    }
}
