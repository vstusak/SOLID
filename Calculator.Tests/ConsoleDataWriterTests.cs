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
        public void WriteValue_InputInt_ExpectedStringIsWrittenToOutput(int value, string expectedString)
        {
            //Arrange
            var underTest = new ConsoleDataWriter();
            //Act
            underTest.WriteValue();

            //Assert
            Assert.Fail("Finish test, check console output.");
        }
    }

}
