using System;
using System.Drawing;

namespace Lesson3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Square();
            rectangle.Height = 5;
            rectangle.Width = 9;

            // cannot instantiate abstract class here: var shape = new Shape();

            Console.WriteLine(rectangle.IsSquare ? "Is square." : "Is rectangle.");
            Console.WriteLine(rectangle.Area());
        }

        public abstract class Shape
        {
            private Color _color;

            public abstract int Area();

            public void SetColor(Color color)
            {
                _color = color;
            }
        }

        public class Rectangle : Shape
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }
            public bool IsSquare => Height == Width;
            public override int Area() { return Height * Width; }                        
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
