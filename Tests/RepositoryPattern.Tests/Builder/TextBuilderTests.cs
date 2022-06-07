using BuilderPattern;
using BuilderPattern.Builder;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace RepositoryPattern.Tests.Builder
{
    [TestFixture]
    public class TextBuilderTests : TestsBase
    {
        private Mock<IDateTimeAdapter> mockEnumerable;

        [SetUp]
        public void SetUp()
        {
            mockEnumerable = MockRepository.Create<IDateTimeAdapter>();
        }

        private TextBuilder CreateTextBuilder()
        {
            var books = new List<Book>();

            return new TextBuilder(books, mockEnumerable.Object);
        }

        [Test]
        public void SetHeader_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textBuilder = CreateTextBuilder();

            // Act
            //var result = textBuilder.SetHeader().Build();
            textBuilder.SetHeader();
            var result = textBuilder._result.ToString();

            // Assert
            //Assert.Fail();
            Assert.AreEqual("Welcome to our library, there is a list of books." + Environment.NewLine, result);
        }

        [Test]
        public void WriteLibrary_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textBuilder = CreateTextBuilder();

            // Act
            var result = textBuilder.WriteLibrary();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void SetFooter_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textBuilder = CreateTextBuilder();

            // Act
            var result = textBuilder.SetFooter();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void AddDateStamp_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textBuilder = CreateTextBuilder();

            // Act
            textBuilder.AddDateStamp();
            var result = textBuilder._result.ToString();

            Thread.Sleep(1000);

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToString(CultureInfo.InvariantCulture) + Environment.NewLine, result);
        }

        [Test]
        public void Build_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textBuilder = CreateTextBuilder();

            // Act
            var result = textBuilder.Build();

            // Assert
            Assert.Fail();
        }
    }
}
