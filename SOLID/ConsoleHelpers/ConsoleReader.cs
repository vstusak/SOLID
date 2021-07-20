using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class ConsoleReader
    {

        private OperatorHelpers _operatorHelpers;

        public ConsoleReader()
        {
            _operatorHelpers = new OperatorHelpers();
        }

        public double ReadAndParseDouble(){return double.Parse(Console.ReadLine());}

        public IOperator ReadandReturnValidOperator()
        { 
            var @operator = Console.ReadKey();
            var selectedOperator = _operatorHelpers.SelectRigthOepratorForReader(@operator);
        
            return _operatorHelpers.ValidateSelectedOperatorforReader(selectedOperator, @operator);
        }       
    }
}
