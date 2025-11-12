using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Calculator.Contracts;
using Moq;

namespace Calculator.Tests
{
    internal class CalculatorHandlerTests
    {
        /// <summary>
        /// Tests E2E process. Read data from console (mock), calculate using correct core method (mock).
        /// Assert data reading (2x value, 1x operator).
        /// Assert only the correct Core method was called. 
        ///
        /// Result from Handler output is the same as on handler input.
        /// Asserting data from console to be implemented.
        /// </summary>
        /// <param name="expectedResult"></param>
        [TestCase(10)] //result can be a totally random number and is not changed between input and output.

        public void Execute_InputData_ExpectedResult(double expectedResult)
        {
            //Arrange
            var readerMock = new Mock<IConsoleDataReader>();
            readerMock.Setup(rm => rm.ReadValue()).Returns(It.IsAny<int>());
            readerMock.Setup(rm => rm.ReadOperator()).Returns(It.IsAny<OperationEnum>());

            var writerMock = new Mock<IConsoleDataWriter>();

            var calculatorCoreMock = new Mock<ICalculatorCore>(MockBehavior.Strict);
            calculatorCoreMock.Setup(ccm => ccm.ProcessInput(It.IsAny<InputData>())).Returns(expectedResult);

            var underTest = new CalculatorConsoleHandler(readerMock.Object, writerMock.Object, calculatorCoreMock.Object);

            //Act
            var result = underTest.Execute();

            //Assert that ReadLine was called twice and ReadOperator once.
            readerMock.Verify(rm => rm.ReadValue(), Times.Exactly(2));
            readerMock.Verify(rm => rm.ReadOperator(), Times.Exactly(1));

            calculatorCoreMock.Verify(ccm => ccm.ProcessInput(It.IsAny<InputData>()), Times.Exactly(1));

            // assert that output from CalculatorCore was not altered by CalculatorHandler 
            Assert.That(result, Is.EqualTo(expectedResult));
            writerMock.Verify(wm=>wm.WriteValue(expectedResult),Times.Exactly(1));
        }
    }
}
