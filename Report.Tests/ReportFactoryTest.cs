using System.Data;
using Moq;
using NUnit.Framework;
using Reports;

namespace Report.Tests
{
    public class ReportFactoryTest
    {
        [Test]
        public void CreateReport_EmptyData_EmptyBody()
        {
            //Arrange
            var expectedDateTime = new DateTime(2025, 1, 23, 8, 55, 24, DateTimeKind.Local);
            
            var dataReaderMock = new Mock<IOurDataReader>(MockBehavior.Strict);
            dataReaderMock.Setup(mock => mock.GetData()).Returns(new Dictionary<string, int>());

            var dateTimeProviderMock = new Mock<IDateTimeProvider>(MockBehavior.Strict);
            dateTimeProviderMock.Setup(mock => mock.UtcNow).Returns(expectedDateTime);

            var headerReaderMock = new Mock<IHeaderReader>(MockBehavior.Strict);
            headerReaderMock.Setup(mock => mock.GetHeader(It.IsAny<HeaderType>())).Returns(String.Empty);

            ReportFactory underTest = new ReportFactory(dataReaderMock.Object, dateTimeProviderMock.Object, headerReaderMock.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Body, Is.EqualTo(string.Empty));
        }

        [Test]
        public void CreateReport_DataReaderWithData_BodyInCorrectFormat()
        {
            //Arrange
            var expectedDateTime = new DateTime(2025, 1, 23, 8, 55, 24);

            var dataReaderMock = new Mock<IOurDataReader>(MockBehavior.Strict);
            dataReaderMock.Setup(mock => mock.GetData()).Returns(new Dictionary<string, int> { { "chleba", 5 } });

            var dateTimeProviderMock = new Mock<IDateTimeProvider>(MockBehavior.Strict);
            dateTimeProviderMock.Setup(mock => mock.UtcNow).Returns(expectedDateTime);

            var headerReaderMock = new Mock<IHeaderReader>(MockBehavior.Strict);
            headerReaderMock.Setup(mock => mock.GetHeader(It.IsAny<HeaderType>())).Returns(String.Empty);

            ReportFactory underTest = new ReportFactory(dataReaderMock.Object, dateTimeProviderMock.Object, headerReaderMock.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Body, Is.EqualTo($"chleba : 5{Environment.NewLine}"));

            //TODO: TDD + project calculator
        }
        [Test]
        public void CreateReport_HeaderTypeEmpoyees_AllInHeader()
        {
            //Arrange
            var expectedDateTime = new DateTime(2025, 1, 23, 8, 55, 24);

            var dataReaderMock = new Mock<IOurDataReader>(MockBehavior.Strict);
            dataReaderMock.Setup(mock => mock.GetData()).Returns(new Dictionary<string, int> { { "chleba", 5 } });

            var headerReaderMock = new Mock<IHeaderReader>(MockBehavior.Strict);
            headerReaderMock.Setup(mock => mock.GetHeader(It.IsAny<HeaderType>())).Returns("All");

            var dateTimeProviderMock = new Mock<IDateTimeProvider>(MockBehavior.Strict);
            dateTimeProviderMock.Setup(mock => mock.UtcNow).Returns(expectedDateTime);

            ReportFactory underTest = new ReportFactory(dataReaderMock.Object, dateTimeProviderMock.Object, headerReaderMock.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Header, Is.EqualTo("All"));
            headerReaderMock.Verify(mock => mock.GetHeader(It.IsAny<HeaderType>()), Times.Exactly(1));
        }
    }
}
