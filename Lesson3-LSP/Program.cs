using System;
using System.Drawing;
using System.Reflection.Metadata;

namespace Lesson3_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var circle = new Circle();
            circle.color = ConsoleColor.Red;
            Rectangle myRect = new Rectangle();
            myRect.color = ConsoleColor.Green;
            myRect.Height = 10;
            myRect.Width = 15;

            var calculator = new Calculator();
            var result = calculator.CalculateArea(myRect);
            Console.ForegroundColor = myRect.color;
            Console.WriteLine(result);
            Console.WriteLine($"is square: {myRect.IsSquare}");
            circle.Radius = 12;
            var resultSquare = calculator.CalculateArea(circle);
            Console.ForegroundColor = circle.color;
            Console.WriteLine(resultSquare);
            Console.ReadLine();
        }

        public class Circle : Shape
        {
            public int Radius { get; set; }

            public override int GetArea()
            {
                return Radius * Radius * 3;
            }
        }


        public class Rectangle : Shape
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public bool IsSquare => Width == Height;

            public override int GetArea()
            {
                return Height * Width;
            }
        }
        
        //public class Square : Rectangle
        //{
        //    private int _width;
        //    private int _height;

        //    public override int Width
        //    {
        //        get { return _width; }
        //        set { _width = _height = value; }
        //    }
        //    public override int Height
        //    {
        //        get { return _height; }
        //        set { _height = _width = value; }
        //    }

        //}

        public class Calculator
        {
            public int CalculateArea(Shape shape)
            {
                return shape.GetArea();
            }
            //public int CalculateArea(Rectangle myRect)
            //{
            //    return myRect.Height * myRect.Width;
            //}

            //public int CalculateArea(Circle circle)
            //{
            //    return circle.Radius * circle.Radius * 3;
            //}
        }
    }

    public abstract class Shape
    {
        public abstract int GetArea();
        public ConsoleColor color { get; set; }

    }
}
