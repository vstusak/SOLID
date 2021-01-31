using SOLID.Data;

namespace SOLID.Operation
{
    interface IOperations
    {
        void Add(InputOutputData inputOutputData);
        void Sub(InputOutputData inputOutputData);
        void Mul(InputOutputData inputOutputData);
        void Div(InputOutputData inputOutputData);
    }
}