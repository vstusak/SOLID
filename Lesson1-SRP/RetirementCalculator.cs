using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson1_SRP;

public class RetirementCalculator
{
    private readonly IBonusProvider _bonusProvider;
    private INewMultiplicationProvider _multiplicationProvider;

    public RetirementCalculator(IBonusProvider bonusProvider, INewMultiplicationProvider multiplicationProvider)
    {
        _bonusProvider = bonusProvider;
        _multiplicationProvider = multiplicationProvider;
    }
    public int Process(int baseSalary)
    {
        var salariesLoader = new SalaryLoader();



        var salaries = salariesLoader.GetSalaries();
        var multiplication = _multiplicationProvider.GetMultiplication(salaries);
        var bonuses = _bonusProvider.GetBonuses(salaries);

        return Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
    }



    //TODO - getSalaryConditions? method - presunout ify
    //public void GenerateSalaries()
    //{
    //    var salaryGenerator = new Random();

    //    var salaries = new List<Salary>();
    //    for (int i = 0; i < 100; i++)
    //    {
    //        salaries.Add(new Salary
    //            { DateTime = new DateTime(2020, 9, 13).AddMonths(i * -1), Value = salaryGenerator.Next(5000, 50000) });
    //    }

    //    var json = JsonSerializer.Serialize(salaries);
    //    File.AppendAllText("salaries.json", json);
    //}
}