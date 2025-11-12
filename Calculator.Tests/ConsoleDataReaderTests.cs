using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Contracts;
using Moq.Language;

namespace Calculator.Tests
{
    internal class ConsoleDataReaderTests
    {
        [TestCase("5", 5)]
        public void ReadValue_Get_ReturnValue(string inputString, int expectedValue)
        {
            //Arrange
            var consoleAdapterMock = new Mock<IConsoleAdapter>();
            //consoleAdapterMock.SetupSequence(ca => ca.ReadLine()).Returns(inputString);
            consoleAdapterMock.Setup(ca => ca.ReadLine()).Returns(inputString);

            var underTest = new ConsoleDataReader(consoleAdapterMock.Object);

            //Act
            var result = underTest.ReadValue();
            //Assert
            Assert.That(result, Is.EqualTo(expectedValue));
        }
        [TestCase("+", OperationEnum.Add)]
        [TestCase("-", OperationEnum.Sub)]
        [TestCase("*", OperationEnum.Mult)]
        [TestCase("/", OperationEnum.Div)]
        public void ReadOperator_Get_MatchToOperationEnum(string inputOperationString, OperationEnum expectedOperationEnum)
        {
            //Arrange
            var consoleAdapterMock = new Mock<IConsoleAdapter>();
            consoleAdapterMock.Setup(ca => ca.ReadLine()).Returns(inputOperationString);
            var underTest = new ConsoleDataReader(consoleAdapterMock.Object);

            // //Act
            var result = underTest.ReadOperator();
            // //Assert
            Assert.That(result, Is.EqualTo(expectedOperationEnum));
        }
        [TestCase("b")]
        [TestCase(":")]
        [TestCase("1")]
        public void ReadOperator_InvalidChar_ThrowsException(string inputOperationString)
        {
            //Arrange
            var consoleAdapterMock = new Mock<IConsoleAdapter>();
            consoleAdapterMock.Setup(ca => ca.ReadLine()).Returns(inputOperationString);
            var underTest = new ConsoleDataReader(consoleAdapterMock.Object);

            // //Act

            // //Assert
            Assert.Catch<ArgumentException>(()=>underTest.ReadOperator());
        }
    }
}