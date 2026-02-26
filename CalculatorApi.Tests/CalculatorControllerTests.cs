using Calculator;
using Calculator.Contracts;
using Calculator.WebApi.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Newtonsoft.Json.Linq;
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
            var controllerApiHandlerMock = new Mock<ICalculatorApiHandler>(MockBehavior.Strict);
            controllerApiHandlerMock.Setup(cahm => cahm.Execute(It.IsAny<InputData>())).Returns(number);
            var loggerMock = new Mock<ILogger<CalculatorController>>();
            var underTest = new CalculatorController(controllerApiHandlerMock.Object, loggerMock.Object);
            InputData inputData = new InputData { Value1 = 1, Value2 = 1, Operation = OperationEnum.Add };
            
            //Act
            var result = underTest.Post(inputData);

            //Assert
            controllerApiHandlerMock.Verify(cahm => cahm.Execute(It.IsAny<InputData>()), Times.Exactly(1));
            Assert.That(result,Is.EqualTo(number));
        }
    }
}