using System;

namespace SOLID;

public class ValueGetter
{
    public ValueGetter()
    {
    }
    public int GetValue1()
    {
        Console.WriteLine("set value 1");
        var value2 = int.Parse(Console.ReadLine());
        return value2;
    }
    public int GetValue2()
    {
        Console.WriteLine("set value 2");
        var value2 = int.Parse(Console.ReadLine());
        return value2;
    }

}