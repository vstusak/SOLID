using SOLID.Data;

namespace SOLID.Operation
{
    interface IOperations
    {
        public void Add(InputOutputData inputOutputData);
        public void Sub(InputOutputData inputOutputData);
        public void Mul(InputOutputData inputOutputData);
        public void Div(InputOutputData inputOutputData);
    }
}