using NUnit.Framework;
using SOLID.Calculator;
using System;

namespace SOLID.Tests
{
    public class CalculatorTests
    {
        [TestCase(1,1,ExpectedResult = 2)]
        [TestCase(-1, 1, ExpectedResult = 0)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1.5, 1.5, ExpectedResult = 3)]
        [TestCase(11.1f, 11.1f, ExpectedResult = 22.2f)]
        public double Add_TwoDoubles_CalculatesResults(double a, double b)
        {
            var logger = new LoggerMock();
            var calculator = new BasicCalculator(logger);
            var operation = new AddOperation();


            var actual = calculator.Calculate(a, b, operation);


            //Any better way? Expect Assert.Equal
            return actual;
        }

        [TestCase(1, 1, ExpectedResult = 0)]
        [TestCase(-1, 1, ExpectedResult = -2)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 6, ExpectedResult = -1)]
        [TestCase(1.5, 1.5, ExpectedResult = 0)]
        public double Subtract_TwoDoubles_CalculatesResults(double a, double b)
        {
            var logger = new LoggerMock();
            var calculator = new BasicCalculator(logger);
            var operation = new SubtractOperation();


            var actual = calculator.Calculate(a, b, operation);
            return actual;
        }

        [Test]
        public void Divide_DividerZero_ThrowsDivideByZeroException()
        {
            var logger = new LoggerMock();
            var calculator = new BasicCalculator(logger);
            var operation = new DivideOperation();

            Assert.Throws<DivideByZeroException>(() => calculator.Calculate(1, 0, operation));
        }

        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(-1, 1, ExpectedResult = -1)]
        [TestCase(6, 3, ExpectedResult = 2)]
        [TestCase(6, 3, ExpectedResult = 2)]
        [TestCase(5, 2, ExpectedResult = 2.5)]
        [TestCase(1.5, 1.5, ExpectedResult = 1)]
        public double Dividide_TwoDoubles_CalculatesResults(double a, double b)
        {
            var logger = new LoggerMock();
            var calculator = new BasicCalculator(logger);
            var operation = new DivideOperation();


            var actual = calculator.Calculate(a, b, operation);

            return actual;
        }

        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(-1, 1, ExpectedResult = -1)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 6, ExpectedResult = 30)]
        [TestCase(1.5, 1.5, ExpectedResult = 2.25)]
        public double Multiply_TwoDoubles_CalculatesResults(double a, double b)
        {
            var logger = new LoggerMock();
            var calculator = new BasicCalculator(logger);
            var operation = new MultiplyOperation();

            var actual = calculator.Calculate(a, b, operation);

            return actual;
        }
    }
}