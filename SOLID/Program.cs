using SOLID;
using System;

class Program
{
    static void Main()
    {
        var calculator = new Calculator();
        Console.WriteLine("Enter the expression (e.g. 3 + 5):");
        var input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[2]);
        Console.WriteLine(calculator.Calculate(a, input[1], b));
    }
}
