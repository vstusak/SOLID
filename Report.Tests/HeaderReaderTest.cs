using NUnit.Framework;
using Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.Tests
{
    internal class HeaderReaderTest
    {
        [TestCase(HeaderType.Employees, "All")]
        [TestCase(HeaderType.Standard, "Hello")]
        [TestCase(HeaderType.Colleagues, "Hi fellows")]
        [TestCase(HeaderType.Friends, "Hi")]

        public void GetHeader_Employees_All(HeaderType headerType, string expected)
        {
            //Arrange
            var underTest = new HeaderReader();

            //Act
            var result = underTest.GetHeader(headerType);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
