using System.Data;
using Moq;
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
            var expectedDateTime = new DateTime(2025, 1, 23, 8, 55, 24);
            //TODO: use data in dataReader not use empty Dictionary 30.1. // formátování pro přehlednost 
            var dataReaderMock = new Mock<IOurDataReader>(MockBehavior.Strict);
            dataReaderMock.Setup(mock => mock.GetData()).Returns(new Dictionary<string, int>());
            DataReader dataReader = new DataReader();

            var dateTimeProviderMock = new Mock<IDateTimeProvider>(MockBehavior.Strict);

            dateTimeProviderMock.Setup(mock => mock.UtcNow).Returns(expectedDateTime);
            ReportFactory underTest = new ReportFactory(dataReader, dateTimeProviderMock.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Header, Is.EqualTo("All"));
            Assert.That(result.Body, Is.EqualTo(string.Empty));
            Assert.That(result.DataCreated, Is.EqualTo(expectedDateTime));
        }
        //TODO: Assert other properties

    }
}
