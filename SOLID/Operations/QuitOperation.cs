using System;

namespace SOLID.Operations
{
    public class QuitOperation : IOperation
    {
        private const string OperationName = "Quit";
        public string GetOperationName()
        {
            return OperationName;
        }

        public string GetOperationSymbol()
        {
            return "q";
        }

        public int Calculate(int addend1, int addend2)
        {
            throw new NotSupportedException("Quit operation does not support calculation");
        }

        public string GetCalculationString(int addend1, int addend2)
        {
            throw new NotSupportedException("Quit operation does not support calculation");
        }
    }
}