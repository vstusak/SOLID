﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Lesson1_SRP.Calculations;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP
{
    public class Program
    {
        // imagine: tato metoda Main je "controller" pro api endpoint "GetMyRetirement"
        // Needs to follow our (imaginary) Business rule:
        //  As a logged-in user I need to be able to call api endpoint to get calculation whether I will need to work during retirement.
        static void Main(string[] args)
        {
            //Pro lidi od roku 1950 je fixní bonus 5,-Kč
            var personBirth = new DateTime(1948,01,01);
            var retirementCalculator = new RetirementCalculator();
            var wordingProvider = new WordingProvider();
            var salariesProvider = new SalariesLoader();
            var outputWriter = new OutputWriter();
            List<Salary> salaries = salariesProvider.GetSalaries();
            //retirementCalculator.GenerateSalaries();
            var retirementSalaryResult = retirementCalculator.CalculateRetirementSalary(salaries, personBirth);

            var outputMessage = wordingProvider.GetOutputMessageForRetirementSalaryCalculation(retirementSalaryResult);

            outputWriter.WriteToConsole(outputMessage);
        }
        //TODO: opravit rozšíření pro rok 1950 (odstranit předávání dat parametry, dodělat pro bonusProvider interface a použít dependency ingestion)

    }
}
