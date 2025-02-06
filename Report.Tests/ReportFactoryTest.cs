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
            var expectedDateTime = new DateTime(2025, 1, 23, 8, 55, 24, DateTimeKind.Local);
            //TODO formátování pro přehlednost 
            var dataReaderMock = new Mock<IOurDataReader>(MockBehavior.Strict);
            dataReaderMock.Setup(mock => mock.GetData()).Returns(new Dictionary<string, int>());

            var dateTimeProviderMock = new Mock<IDateTimeProvider>(MockBehavior.Strict);

            dateTimeProviderMock.Setup(mock => mock.UtcNow).Returns(expectedDateTime);
            ReportFactory underTest = new ReportFactory(dataReaderMock.Object, dateTimeProviderMock.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Header, Is.EqualTo("All"));
            Assert.That(result.Body, Is.EqualTo(string.Empty));
            Assert.That(result.DataCreated, Is.EqualTo(expectedDateTime));
        }

        [Test]
        public void ReportCreationTest2()
        {
            //Arrange
            var expectedDateTime = new DateTime(2025, 1, 23, 8, 55, 24);

            var dataReaderMock = new Mock<IOurDataReader>(MockBehavior.Strict);
            dataReaderMock.Setup(mock => mock.GetData()).Returns(new Dictionary<string, int>{{"chleba", 5}});

            var dateTimeProviderMock = new Mock<IDateTimeProvider>(MockBehavior.Strict);
            dateTimeProviderMock.Setup(mock => mock.UtcNow).Returns(expectedDateTime);

            ReportFactory underTest = new ReportFactory(dataReaderMock.Object, dateTimeProviderMock.Object);

            //Act
            var result = underTest.CreateReport(HeaderType.Employees);

            //Assert
            Assert.That(result.Header, Is.EqualTo("All"));
            Assert.That(result.Body, Is.EqualTo($"chleba : 5{Environment.NewLine}"));
            Assert.That(result.DataCreated, Is.EqualTo(expectedDateTime));

            //TODO: Set correct names for tests
            //TODO: TDD + project calculator
        }
    }
}
