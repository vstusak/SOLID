using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    internal class ConsoleDataWriterTests
    {
        [TestCase(5, "Result is: 5")]
        [TestCase(0.2, "Result is: 0.2")]
        public void WriteValue_InputInt_ExpectedStringIsWrittenToOutput(double value, string expectedString)
        {
            //Arrange
            var consoleAdapterMock = new Mock<IConsoleAdapter>();
            var underTest = new ConsoleDataWriter(consoleAdapterMock.Object);

            //Act
            underTest.WriteValue(value);

            //Assert
            consoleAdapterMock.Verify(wm => wm.WriteLine(expectedString), Times.Exactly(1));
        }
    }

}
