using System;

namespace Lesson3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle square = new Square();
            square.Height = 4;
            square.Width = 9;

            var area = square.Area;
            Console.WriteLine(area);
            
            //if(square is Square)
            //{
            //    Indikátor toho, že jsme nedodrželi principy dědičnosti
            //}
        }

        public class Rectangle
        {
            protected int _height;
            protected int _width;

            public virtual int Height { get => _height; set => _height = value; }
            public virtual int Width { get => _width; set => _width = value; }
            public bool IsSquare => Height == Width;
            public int Area => Height * Width;
        }

        public class Square : Rectangle
        {
            //public override int Height { get => _height; set { _height = value; _width = value; } }
            //public override int Width { get => _height; set { _height = value; } }
            
        }

        public class Calculator
        {
            public int CalculateArea(Rectangle rectangle)
            {
                return rectangle.Height * rectangle.Width;
            }

            public int CalculateArea(Square rectangle)
            {
                return rectangle.Height * rectangle.Height;
            }
        }
    }
}
