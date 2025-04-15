using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    internal class ConsoleDataReaderTests
    {
        [TestCase()]
        public void ReadValue_Get_ReturnValue()
        {
            //Arrange
            var underTest = new ConsoleDataReader();
            var expected = 5;
            //Act
            var result = underTest.ReadValue();
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
