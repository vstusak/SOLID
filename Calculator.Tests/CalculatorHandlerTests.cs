using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Calculator.Tests
{
    internal class CalculatorHandlerTests
    {
        public void Execute_InputData_ExpectedResult(int value1, int value2, OperationEnum operation, double expectedResult)
        {
            //Arrange
            var reader = new Mock<IConsoleDataReader>();
            reader.SetupSequence(rm => rm.ReadValue()).Returns(value1).Returns(value2);
            reader.Setup(rm => rm.ReadOperator()).Returns(operation);
            
            var writer = new Mock<ConsoleDataWriter>();

            var calculatorCore = new Mock<CalculatorCoreCore>();
            //calculatorCoreCore.Setup(ccm => ccm.) //TODO finish calculatorCoreCore mock setup
            
            var underTest = new CalculatorHandler(reader.Object, writer.Object, calculatorCore.Object);
         
            //Act
            var result = underTest.Execute();

            //Assert
            // TODO write asserts
        }
    }
}
