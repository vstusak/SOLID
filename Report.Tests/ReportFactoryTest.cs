using NUnit.Framework;
using Reports;

namespace Report.Tests
{
    public class ReportFactoryTest
    {
        [Test]
        public void ReportCreationTest()
        {
            //Arrange
            //TODO: DataReader should be replaced by mock
            DataReader dataReader = new DataReader();
            ReportFactory underTest = new ReportFactory(dataReader);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Header, Is.EqualTo("All"));
            //TODO: Assert other properties
        }

    }
}
