using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class CalculatorApiHandlerTests
    {
        [TestCase(OperationEnum.Add, 10)]   
        [TestCase(OperationEnum.Sub, 33)]
        [TestCase(OperationEnum.Mult, 50)]
        [TestCase(OperationEnum.Div, 333)]

        public void Execute_InputData_ExpectedResult(OperationEnum operation, double expectedResult)
        {
            //Arrange
            var calculatorCoreMock = new Mock<ICalculatorCore>();
            calculatorCoreMock.Setup(ccm => ccm.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(expectedResult);
            calculatorCoreMock.Setup(ccm => ccm.Div(It.IsAny<double>(), It.IsAny<double>())).Returns(expectedResult);
            calculatorCoreMock.Setup(ccm => ccm.Mult(It.IsAny<int>(), It.IsAny<int>())).Returns(expectedResult);
            calculatorCoreMock.Setup(ccm => ccm.Sub(It.IsAny<int>(), It.IsAny<int>())).Returns(expectedResult);

            var underTest = new CalculatorApiHandler(calculatorCoreMock.Object);

            //Act
            var inputData = new InputData(1, 0, operation);
            var result = underTest.Execute(inputData);

            //Assert
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


            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
