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
        //TODO: Janča musí pustit testy :-)
        [Test]
        public void GetHeader_test()
        {
            //Arrange
            var underTest = new HeaderReader();

            //Act
            var result = underTest.GetHeader(HeaderType.Employees);

            //Assert
            Assert.That(result, Is.EqualTo("All "));
        }
    }
}
