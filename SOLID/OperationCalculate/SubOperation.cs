using SOLID.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OperationCalculate
{
    public class SubOperation : IOperation
    {
        public void Calculate(InputOutputData inputOutputData)
        {
            inputOutputData.Output = inputOutputData.Value1 - inputOutputData.Value2;
        }
    }
}
