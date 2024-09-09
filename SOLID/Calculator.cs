using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SOLID
{
    public class Calculator
    {
        //private readonly object key;

        //ctor
        //public Calculator()
        //{
        //}

        public int Calculate(ConsoleKeyInfo key)
        {
            var addition = new Addition();
            var subtraction = new Subtraction();
            var multiplication = new Multiplication();
            var division = new Division();
            //var key = Console.ReadKey();

            switch (key.KeyChar)
            {

                case '+':
                    addition.Add();
                    break;
                case '-':
                    subtraction.Sub();
                    break;
                case '*':
                    multiplication.Mul();
                    break;
                case '/':
                    division.Div();
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }
            return 0;
        }
    }
}