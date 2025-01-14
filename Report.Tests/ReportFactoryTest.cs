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
            var expectedDateTime = DateTime.UtcNow;
            //TODO: DataReader should be replaced by mock
            DataReader dataReader = new DataReader();
            //TODO: Create mock for dateTimeProvider (23.1.2025)
            ReportFactory underTest = new ReportFactory(dataReader, mockDateTimeProvider.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Header, Is.EqualTo("All"));
            Assert.That(result.Body, Is.EqualTo("světe"));
            Assert.That(result.DataCreated, Is.EqualTo(expectedDateTime));
        }
        //TODO: Assert other properties

    }
}
