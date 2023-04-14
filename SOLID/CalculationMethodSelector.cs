using SOLID.Calculations;
using static SOLID.Program;
using System;

namespace SOLID;

public class CalculationMethodSelector
{
    private readonly CalculationMethodInputter _calculationMethodInputter;
    public CalculationMethodSelector(CalculationMethodInputter calculationMethodInputter)
    {
        _calculationMethodInputter = calculationMethodInputter;
    }

    public ICalculatorMethod SelectCalculationMethod()
    {
        //out ConsoleKeyInfo key
        switch (_calculationMethodInputter.InputCalculationMethod())
        {

            case '+':
                var add = new CalculatorMethodAdd();
                return add;
            case '-':
                var sub = new CalculatorMethodSub();
                return sub;
            case '*':
                var mul = new CalculatorMethodMul();
                return mul;
            case '/':
                var div = new CalculatorMethodDiv();
                return div;
            default:
                Console.WriteLine("Not supported");
                return null;
        }
    }
}