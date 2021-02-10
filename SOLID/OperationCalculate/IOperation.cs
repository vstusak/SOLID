using SOLID.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OperationCalculate
{
    public interface IOperation
    {
        void Calculate(InputOutputData inputOutputData);
    }
}
