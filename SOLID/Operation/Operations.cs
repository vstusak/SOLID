using SOLID.Data;
using System;

namespace SOLID.Operation
{
    public class Operations : IOperations
    {
        public void Add(InputOutputData inputOutputData)
        {
            inputOutputData.Output = inputOutputData.Value1 + inputOutputData.Value2;
        }

        public void Div(InputOutputData inputOutputData)
        {
            if (inputOutputData.Value2 == 0)
            {
                throw new DivideByZeroException();

            }
            inputOutputData.Output = inputOutputData.Value1 / inputOutputData.Value2;
        }

        public void Mul(InputOutputData inputOutputData)
        {
            inputOutputData.Output = inputOutputData.Value1 * inputOutputData.Value2;
        }

        public void Sub(InputOutputData inputOutputData)
        {
            inputOutputData.Output = inputOutputData.Value1 - inputOutputData.Value2;
        }
    }
}
