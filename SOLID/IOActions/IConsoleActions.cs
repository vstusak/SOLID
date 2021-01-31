using SOLID.Data;

namespace SOLID.IOActions
{
    public interface IConsoleActions
    {
        public void GetOperator(InputOutputData inputOutputData, string message);
        public void GetValues(InputOutputData inputOutputData, string message1, string message2);
        public void ReturnResult(InputOutputData inputOutputData);
    }
}