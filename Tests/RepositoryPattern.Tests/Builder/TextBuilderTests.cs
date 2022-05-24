using BuilderPattern;
using BuilderPattern.Builder;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace RepositoryPattern.Tests.Builder
{
    [TestFixture]
    public class TextBuilderTests : TestsBase
    {
        private Mock<IEnumerable<Book>> mockEnumerable;

        [SetUp]
        public void SetUp()
        {
            mockEnumerable = MockRepository.Create<IEnumerable<Book>>();
        }

        private TextBuilder CreateTextBuilder()
        {
            return new TextBuilder(
                mockEnumerable.Object);
        }

        [Test]
        public void SetHeader_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var textBuilder = CreateTextBuilder();

            // Act
            var result = textBuilder.SetHeader();

            // Assert
            Assert.Fail();
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
            var result = textBuilder.AddDateStamp();

            // Assert
            Assert.Fail();
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
