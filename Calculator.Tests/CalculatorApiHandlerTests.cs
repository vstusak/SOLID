using Calculator.Contracts;
using Moq;
using Newtonsoft.Json.Linq;
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
        
        [TestCase( 10)]   

        public void Execute_InputData_ExpectedResult(double expectedResult)
        {
            //Arrange
            var calculatorCoreMock = new Mock<ICalculatorCore>(MockBehavior.Strict);
            
            calculatorCoreMock.Setup(ccm => ccm.ProcessInput(It.IsAny<InputData>())).Returns(expectedResult);
            
            var underTest = new CalculatorApiHandler(calculatorCoreMock.Object);

            //Act
            var inputData = new InputData { Value1 = 1, Value2 = 0, Operation = OperationEnum.Add };
            var result = underTest.Execute(inputData);

            //Assert
            calculatorCoreMock.Verify(ccm => ccm.ProcessInput(It.IsAny<InputData>()), Times.Exactly(1));

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
