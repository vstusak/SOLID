using System.ComponentModel;

namespace Calculator.Contracts
{
    public enum OperationEnum
    {
        Undefined,
        [Description("+")]
        Add,
        [Description("-")]
        Sub,
        [Description("*")]
        Mult,
        [Description("/")]
        Div
    }
}
