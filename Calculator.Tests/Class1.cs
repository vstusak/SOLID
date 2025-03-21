
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [TestCase(1, 2)]
        [TestCase(1, 0)]
        public void Add_InputData_DataAddedTogether(int value1, int value2)
        {
            //Arrange
            var underTest = new TddCalculator();
            //Act
            var result = underTest.Add(value1, value2);
            //Assert
            var expected = value1 + value2;
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, 2)]
        [TestCase(1, 0)]
        public void Sub_InputData_DataSubstituted(int value1, int value2)
        {
            //Arrange
            var underTest = new TddCalculator();
            //Act
            var result = underTest.Sub(value1, value2);
            //Assert
            Assert.That(result, Is.EqualTo(value1 - value2));
        }

        [TestCase(0, 1)]
        [TestCase(1, 2)]
        public void Multiplication_InputData_DataMultiplicated(int value1, int value2)
        {
            //Arrange
            var underTest = new TddCalculator();
            //Act
            var result = underTest.Mult(value1, value2);
            //Assert
            Assert.That(result, Is.EqualTo(value1*value2));
        }

        //TODO 27.03.: Handle divide by zero, do not support
        //TODO: Assertion of double 
        [TestCase(1, 0)]
        public void Division_InputData_DataDivided(double value1, double value2)
        {
            //Arrange
            var underTest = new TddCalculator();
            //Act
            var result = underTest.Div(value1, value2);
            //Assert
            Assert.That(result, Is.EqualTo(value1 / value2));
        }
    }
}
