using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    internal class ConsoleDataReaderTests
    {
        [TestCase("5", 5)]
        public void ReadValue_Get_ReturnValue(string inputString, int expectedValue)
        {
            //Arrange
            var consoleAdapterMock = new Mock<IConsoleAdapter>();
            //TODO: finish setup
            consoleAdapterMock.SetupSequence(ca => ca.ReadLine()).Returns
            var underTest = new ConsoleDataReader(consoleAdapterMock.Object);

            //Act
            var result = underTest.ReadValue();
            //Assert
            Assert.That(result, Is.EqualTo(expectedValue));
        }

        //[TestCase("+", OperationEnum.Add)]
        //[TestCase("-", OperationEnum.Sub)]
        //[TestCase("*", OperationEnum.Mult)]
        //[TestCase("/", OperationEnum.Div)]
        //public void ReadOperator_Get_MatchToOperationEnum(string inputOperationString, OperationEnum expectedOperationEnum)
        //{
        //    //Arrange
        //    var underTest = new ConsoleDataReader();
        //    // //Act
        //    var result = underTest.ReadOperator();
        //    // //Assert
        //    Assert.That(result, Is.EqualTo(expectedOperationEnum));
        //}
    }


}
