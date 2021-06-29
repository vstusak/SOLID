using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class InputProvider
    {
        private int GetInput1()
        {
            Console.WriteLine("\nset value 1");
            return int.Parse(Console.ReadLine());
        }

        private int GetInput2()
        {
            Console.WriteLine("\nset value 2");
            return int.Parse(Console.ReadLine());
        }

        private char GetOperand()
        {
            Console.WriteLine("\nset Operand");
            return char.Parse(Console.ReadLine());
        }

        public InputModel GetInputModel()
        {
            var inputModel = new InputModel();

            inputModel.Input1 = GetInput1();
            inputModel.Input2 = GetInput2();
            inputModel.Operand = GetOperand();

            return inputModel;
        }


    }
}
