using System;
using System.IO;

namespace SOLID;

public class ResultsManager
{
    private readonly Calculator _calculator;
    public ResultsManager(Calculator calculator)
    {
        _calculator = calculator;
    }

    public void ManageResults()
    {
        var resultMessage = _calculator.Calculate();
        Console.WriteLine(resultMessage);
        File.AppendAllText("salaries.json", $"{DateTime.UtcNow} : {resultMessage}\n");
    }
}