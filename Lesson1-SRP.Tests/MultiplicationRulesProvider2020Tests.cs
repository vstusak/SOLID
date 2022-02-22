using Lesson1_SRP.Entities;
using Lesson1_SRP.RulesProviders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class MultiplicationRulesProvider2020Tests
    {
        public void ApplyRulesForMultiplication_SalariesLessThan50_DoesNotUpdateMultiplication()
        {
            //Arrange
            var salaries = new List<Salary>()
            {
                new Salary()
                {
                    Value = 1,
                    DateTime = new DateTime(2020,1,1)
                }
            };
            var multiplication = 1.0;
            var expectedResult = 1.0;
            var unitUnderTest = new MultiplicationRulesProvider2020();

            //Act
            var actualResult = unitUnderTest.ApplyRulesForMultiplication(salaries, multiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
