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
        /// <summary>
        /// Tests E2E process. Read data from console (mock), calculate using correct core method (mock).
        /// Assert data reading (2x value, 1x operator).
        /// Assert only the correct Core method was called. 
        ///
        /// Result from Handler output is the same as on handler input.
        /// Asserting data from console to be implemented.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="expectedResult"></param>
        [TestCase(OperationEnum.Add, 10)] //result can be a totally random number and is not changed between input and output.
        [TestCase(OperationEnum.Sub, 33)]
        [TestCase(OperationEnum.Mult, 50)]
        [TestCase(OperationEnum.Div, 333)]

        public void Execute_InputData_ExpectedResult(OperationEnum operation, double expectedResult)
        {
            //Arrange
            var readerMock = new Mock<IConsoleDataReader>();
            readerMock.Setup(rm => rm.ReadValue()).Returns(It.IsAny<int>());
            readerMock.Setup(rm => rm.ReadOperator()).Returns(operation);

            var writerMock = new Mock<IConsoleDataWriter>();

            var calculatorCoreMock = new Mock<ICalculatorCore>();
            calculatorCoreMock.Setup(ccm => ccm.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(expectedResult);
            calculatorCoreMock.Setup(ccm => ccm.Div(It.IsAny<double>(), It.IsAny<double>())).Returns(expectedResult);
            calculatorCoreMock.Setup(ccm => ccm.Mult(It.IsAny<int>(), It.IsAny<int>())).Returns(expectedResult);
            calculatorCoreMock.Setup(ccm => ccm.Sub(It.IsAny<int>(), It.IsAny<int>())).Returns(expectedResult);

            var underTest = new CalculatorHandler(readerMock.Object, writerMock.Object, calculatorCoreMock.Object);

            //Act
            var result = underTest.Execute();

            //Assert

            //Assert that ReadLine was called twice and ReadOperator once.
            readerMock.Verify(rm => rm.ReadValue(), Times.Exactly(2));
            readerMock.Verify(rm => rm.ReadOperator(), Times.Exactly(1));

            switch (operation) // assert, that only the correct operation was called once
            {
                case OperationEnum.Add:
                    calculatorCoreMock.Verify(ccm => ccm.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(1));
                    calculatorCoreMock.Verify(ccm => ccm.Div(It.IsAny<double>(), It.IsAny<double>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Mult(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Sub(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    break;
                case OperationEnum.Sub:
                    calculatorCoreMock.Verify(ccm => ccm.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Div(It.IsAny<double>(), It.IsAny<double>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Mult(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Sub(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(1));
                    break;
                case OperationEnum.Mult:
                    calculatorCoreMock.Verify(ccm => ccm.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Div(It.IsAny<double>(), It.IsAny<double>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Mult(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(1));
                    calculatorCoreMock.Verify(ccm => ccm.Sub(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    break;
                case OperationEnum.Div:
                    calculatorCoreMock.Verify(ccm => ccm.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Div(It.IsAny<double>(), It.IsAny<double>()), Times.Exactly(1));
                    calculatorCoreMock.Verify(ccm => ccm.Mult(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    calculatorCoreMock.Verify(ccm => ccm.Sub(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
                    break;
                case OperationEnum.Undefined:
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }

            // assert that output from CalculatorCore was not altered by CalculatorHandler 
            Assert.That(result, Is.EqualTo(expectedResult));
            writerMock.Verify(wm=>wm.WriteValue(expectedResult),Times.Exactly(1));
        }
    }
}
