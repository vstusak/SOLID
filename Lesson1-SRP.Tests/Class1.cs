using FluentAssertions;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class MultiplicationRulesProviderTests
    {
        [Fact]
        public void ApplyRules_3SalariesSalariesAverage20kMultiplication01_ExpectedMultiplication01()
        {
            //Arrange
            var unitUnderTest = new MultiplicationRulesProvider();
            var salaries = new List<Salary>
            {
                new()
                {
                    DateTime = DateTime.UtcNow,
                    Value = 10000
                },
                new()
                {
                    DateTime = DateTime.UtcNow,
                    Value = 20000
                },
                new()
                {
                    DateTime = DateTime.UtcNow,
                    Value = 30000
                },
            };
            const double defaultMultiplication = 0.1;
            const double expectedResult = 0.1;

            //Act
            var actualResult = unitUnderTest.ApplyRules(salaries, defaultMultiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ApplyRules_3SalariesSalariesAverageMoreThan30kMultiplication01_ExpectedMultiplication11()
        {
            //Arrange
            var unitUnderTest = new MultiplicationRulesProvider();
            var salaries = new List<Salary>
            {
                new()
                {
                    DateTime = DateTime.UtcNow,
                    Value = 30000
                },
                new()
                {
                    DateTime = DateTime.UtcNow,
                    Value = 31000
                },
                new()
                {
                    DateTime = DateTime.UtcNow,
                    Value = 30000
                },
            };
            const double defaultMultiplication = 0.1;
            const double expectedResult = 1.1;

            //Act
            var actualResult = unitUnderTest.ApplyRules(salaries, defaultMultiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ApplyRules_55SalariesSalariesAverageMoreThan30kMultiplication01_ExpectedMultiplication14()
        {
            //Arrange
            var unitUnderTest = new MultiplicationRulesProvider();
            var salaries = new List<Salary>();
            for (var i = 0; i < 55; i++)
            {
                salaries.Add(new Salary
                {
                    DateTime = DateTime.UtcNow,
                    Value = 31000
                });
            }
            const double defaultMultiplication = 0.1;
            const double expectedResult = 1.4;

            //Act
            var actualResult = unitUnderTest.ApplyRules(salaries, defaultMultiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 20000, 0.1, 0.1)]
        [InlineData(3, 31000, 0.1, 1.1)]
        [InlineData(55, 31000, 0.1, 1.4)]
        [InlineData(55, 20000, 0.1, 0.4)]
        [InlineData(3, 20000, 0.2, 0.2)]
        public void ApplyRules_TheoryInput(int salaryCount, int salaryValue, double defaultMultiplication, double expectedResult)
        {
            //Arrange
            var unitUnderTest = new MultiplicationRulesProvider();
            var salaries = new List<Salary>();
            for (var i = 0; i < salaryCount; i++)
            {
                salaries.Add(new Salary
                {
                    DateTime = DateTime.UtcNow,
                    Value = salaryValue
                });
            }

            //Act
            var actualResult = unitUnderTest.ApplyRules(salaries, defaultMultiplication);
            
            //Assert
            Assert.Equal(expectedResult, actualResult); //Assert with xUnit default Assert
            actualResult.Should().Be(expectedResult); //Assert with Fluent Assertions
            //Probrat Assert Extensions
        }

        [Fact]
        public void ApplyRules_NullSalariesList_MultiplicationIsNotChanged()
        {
            //Arrange
            var unitUnderTest = new MultiplicationRulesProvider();
            var defaultMultiplication = 123.0;
            var expectedResult = 123.0;

            //Act
            var actualResult = unitUnderTest.ApplyRules(null, defaultMultiplication);

            //Assert
            Assert.Equal(expectedResult, actualResult); //Assert with xUnit default Assert
            actualResult.Should().Be(expectedResult); //Assert with Fluent Assertions
        }

        [Fact]
        public void ApplyRules_MoreThan100SalariesList_CriticalCountOfSalariesException()
        {
            //Arrange
            var unitUnderTest = new MultiplicationRulesProvider();
            var defaultMultiplication = 123.0;
            var expectedResult = 123.0;

            var salaries = new List<Salary>();
            for (var i = 0; i < 101; i++)
            {
                salaries.Add(new Salary
                {
                    DateTime = DateTime.UtcNow,
                    Value = 123
                });
            }

            //Act and Assert
            Assert.Throws<CriticalCountOfSalariesException>(() =>
                unitUnderTest.ApplyRules(salaries, defaultMultiplication));

            Action act = () => unitUnderTest.ApplyRules(salaries, defaultMultiplication);
            act.Should().Throw<CriticalCountOfSalariesException>()
                .WithInnerException<ArgumentException>()
                .WithMessage("whatever");

            //Dodelat custom fluent assertion, ktera vrati Exception
        }

    }
}
