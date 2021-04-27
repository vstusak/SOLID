using System;

namespace Lesson3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var square = new Square();
            Rectangle myRect = new Rectangle();
            myRect.Height = 10;
            myRect.Width = 15;

            var calculator = new Calculator();
            var result = calculator.CalculateArea(myRect);
            Console.WriteLine(result);

            square.Width = 12;
            square.Height = 8;
            var resultSquare = calculator.CalculateArea(square);
            Console.WriteLine(resultSquare);

            Console.ReadLine();
        }

        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }
        }

        public class Square : Rectangle
        {
            private int _width;
            private int _height;

            public override int Width
            {
                get { return _width; }
                set { _width = _height = value; }
            }
            public override int Height
            {
                get { return _height; }
                set { _height = _width = value; }
            }

        }

        public class Calculator
        {
            public int CalculateArea(Rectangle myRect)
            {
                return myRect.Height * myRect.Width;
            }
        }
    }
}
