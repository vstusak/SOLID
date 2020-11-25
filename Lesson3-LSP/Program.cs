using System;

namespace Lesson3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Square();
            rectangle.Height = 5;
            rectangle.Width = 9;

            Console.WriteLine(rectangle.IsSquare ? "Is square." : "Is rectangle.");
            Console.WriteLine(rectangle.Area);
        }

        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }
            public bool IsSquare => Height == Width;
            public int Area => Height * Width;
        }

        public class Square : Rectangle
        {
            
        }

        public class Calculator
        {
            public int CalculateArea(Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }
        }
    }
}
