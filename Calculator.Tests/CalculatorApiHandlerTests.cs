using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Contracts;

namespace Calculator.Tests
{
    public class CalculatorApiHandlerTests
    {
        
        [TestCase( 10)]   

        public void Execute_InputData_ExpectedResult(double expectedResult)
        {
            //Arrange
            var calculatorCoreMock = new Mock<ICalculatorCore>(MockBehavior.Strict);
            
            calculatorCoreMock.Setup(ccm => ccm.ProcessInput(It.IsAny<InputData>())).Returns(expectedResult);
            
            var underTest = new CalculatorApiHandler(calculatorCoreMock.Object);

            //Act
            var inputData = new InputData(1, 0, OperationEnum.Add);
            var result = underTest.Execute(inputData);

            //Assert
            calculatorCoreMock.Verify(ccm => ccm.ProcessInput(It.IsAny<InputData>()), Times.Exactly(1));

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
