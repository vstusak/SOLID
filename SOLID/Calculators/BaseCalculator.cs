﻿using System;

namespace SOLID
{
    partial class Program
    {
        public class BaseCalculator : ICalculator
        {
            private (int,int) GetInputs()
            {
                Console.WriteLine("\nset value 1");
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("set value 2");
                var b = int.Parse(Console.ReadLine());
                return (a, b);
            }

            private IOperation GetOperation(int a, int b)
            {
                Console.WriteLine("Set Command (+. -, *, /");
                var key = Console.ReadKey();

                return key.KeyChar switch
                {
                    '+' => new Add(a, b),
                    '-' => new Sub(a, b),
                    '*' => new Mul(a, b),
                    '/' => new Div(a, b),
                    _ => throw new NotImplementedException("Not supported"),
                };
            }

            public int Calculate()
            {
                (var a, var b) = GetInputs();
                var operation = GetOperation(a, b);
                return operation.Execute();
            }
        }
    }
}
