using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class OperatorHelpers
    {
        private const char _operatorPlus = '+';
        private const char _operatorMinus = '-';
        private const char _operatorDivide = '/';
        private const char _operatorMultipy = '*';

        public IOperator ValidateSelectedOperatorforReader(IOperator selectedOperator, ConsoleKeyInfo @operator)
        {
            while (selectedOperator == null) // array of valid chars, regularny výraz 
            {
                Console.WriteLine("\nInvalid operator");
                Console.WriteLine("Set valid operator (+, -, *, /)");
                @operator = Console.ReadKey();
                selectedOperator = SelectRigthOepratorForReader(@operator);
            }
            return selectedOperator;
        }
        public IOperator SelectRigthOepratorForReader(ConsoleKeyInfo @operator) // add to calculator class,  Reader - string not to work with classes, work with strings
        {
            switch (@operator.KeyChar)
            {
                case _operatorPlus:
                    return new Addition();
                case _operatorMinus:
                    return new Substraction();
                case _operatorMultipy:
                    return new Multiplication();
                case _operatorDivide:
                    return new Division();
                default:
                     throw new InvalidOperatorException(); // do not return null, return exceptions 
            }
        }

        public Char SelectRightOperatorForWriter(IOperator @operator)
        {
            if (@operator is Addition)
            {
                return _operatorPlus;
            }
            else if (@operator is Substraction)
            {
                return _operatorMinus;
            }
            else if (@operator is Multiplication)
            {
                return _operatorMultipy;
            }
            else if (@operator is Division)
            {
                return _operatorDivide;
            }

            return 'N';
        }

    }

    public class InvalidOperatorException : Exception
    {
        public InvalidOperatorException() //exception pattern three constructors 
        {

        }
    }
}
