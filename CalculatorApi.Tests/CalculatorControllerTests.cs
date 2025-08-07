using Calculator;
using CalculatorApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CalculatorApi.Tests
{
    public class CalculatorControllerTests
    {
        [TestCase]
        public void Post_InputData_DataAreProcessedByCalculator()
        {
            //Arrange
            var number = 1;
            var contorllerApiHandlerMock = new Mock<ICalculatorApiHandler>(MockBehavior.Strict);
            contorllerApiHandlerMock.Setup(cahm => cahm.Execute(It.IsAny<InputData>())).Returns(number);
            var loggerMock = new Mock<ILogger<CalculatorController>>();
            var underTest = new CalculatorController(contorllerApiHandlerMock.Object, loggerMock.Object);
            InputData inputData = new InputData(1, 1, OperationEnum.Add);
            
            //Act
            var result = underTest.Post(inputData);

            //Assert
            contorllerApiHandlerMock.Verify(cahm => cahm.Execute(It.IsAny<InputData>()), Times.Exactly(1));
            Assert.That(result,Is.EqualTo(number));
        }
    }
}