using System;

namespace Lesson3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();
            square.
            Console.WriteLine("Hello World!");
        }

        public abstract class Shape
        {
            public abstract int GetArea();
        }
        public class Rectangle : Shape
        {
            public int a { get; set; }
            public int b { get; set; }
            public override int GetArea()
            {
                return a * b;
            }
        }

        public class Square : Shape
        {
            public int a { get; set; }

            public override int GetArea()
            {
                return a * a;
            }
        }

        public class Calculator
        {
           public int CalculateArea(Shape s)
            {
                return s.GetArea();
            }
        }
    }
}
