using System;
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
            //if (args.Length != 1)
            //{
            //    throw new ArgumentException("Application started with wrong number of parameters.");
            //}


            //if (!File.Exists(salarySourcePath))
            //{
            //    throw new ArgumentException("File doesnt exist.");
            //}

            IInputValidator _validator = new InputValidator();
            var validationResult = _validator.ValidateInput(args);

            if (validationResult.IsValid())
            {
                throw new ArgumentException(validationResult.GetMessages());
            }

            var salarySourcePath = args.First();


            // DONE validation method for args - 1) file exists, 2) file is in json format (maybe not)
            // DONE extract method to separate class
            // TODO app run based on user input (select salaries source file while application is running)
            // TODO revert finished DONEs and implement from usage point of view

            //Pro lidi od roku 1950 je fixní bonus 5,-Kč
            var personBirth = new DateTime(1948, 01, 01);
            //var bonusProvider = new BonusProvider();
            IBonusProvider bonusProvider;
            if (personBirth.Year >= 1950)
            {
                bonusProvider = new BonusProvider1950AndYounger();
            }
            else
            {
                bonusProvider = new BonusProvider();
            }

            var multiplicationProvider = new MultiplicationProvider();

            var retirementCalculator = new RetirementCalculator(bonusProvider, multiplicationProvider);
            var wordingProvider = new WordingProvider();
            var salariesProvider = new SalariesLoader();
            var outputWriter = new OutputWriter();
            List<Salary> salaries = salariesProvider.GetSalaries(salarySourcePath);
            //retirementCalculator.GenerateSalaries();
            var retirementSalaryResult = retirementCalculator.CalculateRetirementSalary(salaries);

            var outputMessage = wordingProvider.GetOutputMessageForRetirementSalaryCalculation(retirementSalaryResult);

            outputWriter.WriteToConsole(outputMessage);
        }

    }

    internal class InputValidator : IInputValidator
    {
        public AcademyValidationResult ValidateInput(string[] args)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IInputValidator
    {
        AcademyValidationResult ValidateInput(string[] args);
    }

    internal class AcademyValidationResult
    {
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public string GetMessages()
        {
            throw new NotImplementedException();
        }
    }
}
