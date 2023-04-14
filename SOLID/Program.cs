using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using SOLID.Calculations;

namespace SOLID
{
    //call new object Calculator -> method Calculate
    //method calculate should return Result
    //5-7 rows
    //only Main in class Program
    class Program
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator(new ValueGetter().GetValue1(), new ValueGetter().GetValue2(), new CalculationMethodSelector(new CalculationMethodInputter()).SelectCalculationMethod());
            var resultsManager = new ResultsManager(calculator);

            calculator.Calculate();
            resultsManager.ManageResults();
        }
    }
}
