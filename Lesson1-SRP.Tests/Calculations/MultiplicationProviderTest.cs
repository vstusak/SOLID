using Lesson1_SRP.Calculations;
using Lesson1_SRP.Entities;
using Xunit;

namespace Lesson1_SRP.Tests.Calculations
{

    public class MultiplicationProviderTest
    {
        //given-> when-> then
        //when-> given-> then
        [Fact]
        public void EmptyList_GetMultiplication_1()
        {
            //arrange
            List<Salary> emptySalaries = new List<Salary>();
            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 1;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(emptySalaries);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_1_valueLessThan30000_GetMultiplication_1()
        {
            //arrange
            var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 7300 };
            List<Salary> oneSalary = new List<Salary>();
            oneSalary.Add(salary);
            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 1;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(oneSalary);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_50_valueLessThan30000_GetMultiplication_1()
        {
            //arrange
            List<Salary> salaries = new List<Salary>();

            for (int i = 0; i < 50; i++)
            {
                var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 7300 };
                salaries.Add(salary);
            }

            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 1;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(salaries);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_51_valueLessThan30000_GetMultiplication_1point3()
        {
            //arrange
            List<Salary> salaries = new List<Salary>();

            for (int i = 0; i < 51; i++)
            {
                var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 7300 };
                salaries.Add(salary);
            }

            var multiplicationProvider = new MultiplicationProvider();
            double expectedResult = 1.3;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(salaries);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_1_valueMoreThan30000_GetMultiplication_2()
        {
            //arrange
            var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 33333 };
            List<Salary> oneSalary = new List<Salary>();
            oneSalary.Add(salary);
            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 2;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(oneSalary);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_1_value30000_GetMultiplication_1()
        {
            //arrange
            var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 30000 };
            List<Salary> oneSalary = new List<Salary>();
            oneSalary.Add(salary);
            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 1;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(oneSalary);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_50_valueMoreThan30000_GetMultiplication_2()
        {
            //arrange
            List<Salary> salaries = new List<Salary>();

            for (int i = 0; i < 50; i++)
            {
                var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 33333 };
                salaries.Add(salary);
            }

            var multiplicationProvider = new MultiplicationProvider();
            int expectedResult = 2;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(salaries);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }

        [Fact]
        public void SalaryCount_51_valueMoreThan30000_GetMultiplication_2point3()
        {
            //arrange
            List<Salary> salaries = new List<Salary>();

            for (int i = 0; i < 51; i++)
            {
                var salary = new Salary() { DateTime = new DateTime(1990, 2, 1), Value = 33333 };
                salaries.Add(salary);
            }

            var multiplicationProvider = new MultiplicationProvider();
            double expectedResult = 2.3;
            //act
            var actualResult = multiplicationProvider.GetMultiplication(salaries);
            //assert
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
    }
}
