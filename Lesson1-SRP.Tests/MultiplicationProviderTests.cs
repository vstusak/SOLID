using System;
using System.Collections.Generic;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class MultiplicationProviderTests
    {
        [Fact]
        public void ThreeSalariesLessThan30000DefaultMultiplication01_ApplyRules_FinalMultiplication01()
        {
            //Arrange
            MultiplicationProvider underTest = new MultiplicationProvider();
            const double defaultMultiplication = 0.1;
            const double expectedMultiplication = 0.1;

            var listOfSalaries = new List<Salary>
            {
                new() { DateTime = DateTime.Now, Value = 25000 },
                new() { DateTime = DateTime.Now, Value = 25000 },
                new() { DateTime = DateTime.Now, Value = 25000 }
            };
            //Act
            var finalMultiplication = underTest.ApplyRules(defaultMultiplication, listOfSalaries);

            //Assert
            Assert.Equal(expectedMultiplication, finalMultiplication);
        }

        [Fact]
        public void HundredSalariesLessThan30000DefaultMultiplication01_ApplyRules_FinalMultiplication04()
        {
            //Arrange
            MultiplicationProvider underTest = new MultiplicationProvider();
            const double defaultMultiplication = 0.1;
            const double expectedMultiplication = 0.4;

            var listOfSalaries = new List<Salary>();
            for (int i = 0; i < 100; i++)
            {
                listOfSalaries.Add(new Salary { DateTime = DateTime.Now, Value = 25000 });
            }

            //Act
            var finalMultiplication = underTest.ApplyRules(defaultMultiplication, listOfSalaries);

            //Assert
            Assert.Equal(expectedMultiplication, finalMultiplication);
        }

        // Both tests merged to the one theory
        [Theory]
        [InlineData(0.1, 3, 25000, 0.1)]
        [InlineData(0.1, 100, 25000, 0.4)]
        [InlineData(0.1, 3, 35000, 1.1)]
        [InlineData(0.1, 100, 35000, 1.4)]
        [InlineData(0.5, 3, 25000, 0.5)]
        public void GivenData_ApplyRules_ExpectedMultiplication(double defaultMultiplication, int numberOfSalaries, int averageSalary, double expectedMultiplication)
        {
            //Arrange
            MultiplicationProvider underTest = new MultiplicationProvider();

            var listOfSalaries = new List<Salary>();
            for (var i = 0; i < numberOfSalaries; i++)
            {
                listOfSalaries.Add(new Salary { DateTime = DateTime.Now, Value = averageSalary });
            }

            //Act
            var actualResult = underTest.ApplyRules(defaultMultiplication, listOfSalaries);

            //Assert
            Assert.Equal(expectedMultiplication, actualResult);
        }

        [Fact]
        public void NullListOfSalaries_ApplyRules_ExpectSameMultiplicationsAsInput()
        {
            //Arrange
            MultiplicationProvider underTest = new MultiplicationProvider();
            const double defaultMultiplication = 0.1;
            const double expectedMultiplication = 0.1;

            List<Salary> listOfSalaries = null; 

            //Act
            var finalMultiplication = underTest.ApplyRules(defaultMultiplication, listOfSalaries);

            //Assert
            Assert.Equal(expectedMultiplication, finalMultiplication);
        }

        public void HundredSalaries_ApplyRules_TooManySalariesException()
        {
            //Arrange
            MultiplicationProvider underTest = new MultiplicationProvider();

            var listOfSalaries = new List<Salary>();
            for (var i = 0; i < 100; i++)
            {
                listOfSalaries.Add(new Salary { DateTime = DateTime.Now, Value = 25 });
            }

            //Act         

            //Assert
            Assert.Throws<TooManySalariesException>(() => underTest.ApplyRules(0.1, listOfSalaries));
        }
    }
}