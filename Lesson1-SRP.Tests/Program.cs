using Lesson1_SRP.Tests.Calculations;

namespace Lesson1_SRP.Tests;

public class Program
{
    public static void Main(string[] args)
    {
        var multiplicationProviderTest = new MultiplicationProviderTest();
        multiplicationProviderTest.EmptyList_GetMultiplication_1();
        multiplicationProviderTest.SalaryCount_1_value30000_GetMultiplication_1();
        multiplicationProviderTest.SalaryCount_1_valueLessThan30000_GetMultiplication_1();
        multiplicationProviderTest.SalaryCount_1_valueMoreThan30000_GetMultiplication_2();
        multiplicationProviderTest.SalaryCount_50_valueLessThan30000_GetMultiplication_1();
        multiplicationProviderTest.SalaryCount_50_valueMoreThan30000_GetMultiplication_2();
        multiplicationProviderTest.SalaryCount_51_valueLessThan30000_GetMultiplication_1point3();
        multiplicationProviderTest.SalaryCount_51_valueMoreThan30000_GetMultiplication_2point3();

        Console.WriteLine("All tests has run");
        Console.ReadKey();
    }

}