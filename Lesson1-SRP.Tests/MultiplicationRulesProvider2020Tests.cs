using Lesson1_SRP.Entities;
using Lesson1_SRP.RulesProviders;
using System;
using System.Collections.Generic;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class MultiplicationRulesProvider2020Tests
    {
        [Fact]
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

        [Fact]
        public void ApplyRulesForMultiplication_SalariesMoreThan50_DoesUpdateMultiplication()
        {
            //Arrange
            var salaries = new List<Salary>();
            for (int i = 0; i < 51; i++)
            {
                salaries.Add(new Salary()
                {
                    Value = 1,
                    DateTime = new DateTime(2020, 1, 1)
                });
            }
            var multiplication = 1.0;
            var expectedResult = 1.3;
            var unitUnderTest = new MultiplicationRulesProvider2020();

            //Act
            var actualResult = unitUnderTest.ApplyRulesForMultiplication(salaries, multiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, 1, 1, 1.0)]
        [InlineData(51, 30001, 1, 2.3)]
        [InlineData(51, 1, 1, 1.3)]
        [InlineData(1, 30001, 1, 2.0)]
        [InlineData(1, 1, 2.0, 2.0)]
        public void ApplyRulesForMultiplication_InputData_ExpectedResults(int salariesCount, int salaryValue, double multiplication, double expectedResult)
        {
            //Arrange
            var salaries = new List<Salary>();
            for (int i = 0; i < salariesCount; i++)
            {
                salaries.Add(new Salary()
                {
                    Value = salaryValue,
                    DateTime = new DateTime(2020, 1, 1)
                });
            }
            var unitUnderTest = new MultiplicationRulesProvider2020();

            //Act
            var actualResult = unitUnderTest.ApplyRulesForMultiplication(salaries, multiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ApplyRulesForMultiplication_InputDataNull_SameMultiplication()
        {
            //Arrange
            IEnumerable<Salary> salaries = null;
            double multiplication = 1.0;
            double expectedResult = 1.0;

            var unitUnderTest = new MultiplicationRulesProvider2020();

            //Act
            var actualResult = unitUnderTest.ApplyRulesForMultiplication(salaries, multiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
