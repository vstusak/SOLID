using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOLID.Calculator;

namespace SOLID
{
    public static class OperationFactory
    {
        #warning This looks weird, how should I handle mutable objects within static classes?
        private static readonly List<IOperation> _operations = new List<IOperation>()
        {
            new AddOperation(),
            new SubtractOperation(),
            new MultiplyOperation(),
            new DivideOperation()
        };


        public static IEnumerable<char> AvailableCommands() => _operations.Select(o => o.AcceptedInput);

        public static IOperation Create(char input)
        {
            return _operations.Where(o => o.AcceptedInput == input).FirstOrDefault();
        }
    }
}
