using System.Collections.Generic;

namespace SOLID
{
    public class OperationsProvider
    {
        private Dictionary<char, IOperation> _operations;

        public OperationsProvider()
        {
            _operations = new Dictionary<char, IOperation>();
            var addition = new AddOperation();
            _operations.Add(addition.Operator, addition);

            var subtraction = new SubOperation();
            _operations.Add(subtraction.Operator, subtraction);

            var multiplication = new MulOperation();
            _operations.Add(multiplication.Operator, multiplication);

            var division = new DivOperation();
            _operations.Add(division.Operator, division);
        }
        
        public bool OperationExists (char op)
        {
            return _operations.ContainsKey(op);
        }
            

        public IOperation GetOperation(char Name)
        {
            return _operations[Name];                
        }

        public IEnumerable<char> GetAvailableOperators()
        {
            return _operations.Keys;
        }


    }
}
