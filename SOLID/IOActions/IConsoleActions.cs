using SOLID.Data;

namespace SOLID.IOActions
{
    public interface IConsoleActions
    {
        void GetOperator(InputOutputData inputOutputData, string message);
        void GetValues(InputOutputData inputOutputData, string message1, string message2);
        void ReturnResult(InputOutputData inputOutputData);
    }
}