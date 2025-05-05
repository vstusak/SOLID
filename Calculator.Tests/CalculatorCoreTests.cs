
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorCoreCoreTests
    {
        [TestCase(1, 2)]
        [TestCase(1, 0)]
        public void Add_InputData_DataAddedTogether(int value1, int value2)
        {
            //Arrange
            var underTest = new CalculatorCoreCore();
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
            var underTest = new CalculatorCoreCore();
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
            var underTest = new CalculatorCoreCore();
            //Act
            var result = underTest.Mult(value1, value2);
            //Assert
            Assert.That(result, Is.EqualTo(value1*value2));
        }
        
        //TODO: Chceme funkcni kalkulacku. Mame jen jednu tridu se zakladnimi operacemi
        [TestCase(1, 1)]
        public void Division_InputData_DataDivided(double value1, double value2)
        {
            //Arrange
            var underTest = new CalculatorCoreCore();
            var deviationLimit = 0.005;
            var expected = value1 / value2;
            //Act
            var result = underTest.Div(value1, value2);
            var realDeviation = Math.Abs(result - expected);
            //Assert
            Assert.That(realDeviation, Is.LessThan(deviationLimit));
        }

        [TestCase(1)]
        public void Division_DivideByZero_ExceptionIsThrown(double value1)
        {
            //Arrange
            var underTest = new CalculatorCoreCore();
            //All values should be in variables, do not want magic numbers :)
            //Anyway hardcoded according to the test name
            var zero = 0;

            //Act & Assert
            var ex = Assert.Throws(typeof(DivideByZeroException), () => underTest.Div(value1, zero));
            Assert.That(ex.Message, Is.EqualTo($"You are trying divide {value1} by 0."));
        }
    }
}
