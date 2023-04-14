using System;

namespace SOLID;

public class CalculationMethodInputter

{
    public CalculationMethodInputter()
    {
    }
    public char InputCalculationMethod()
    {
        Console.WriteLine("Set Command (+. -, *, /)");
        var key = Console.ReadKey();
        return key.KeyChar;
    }
}