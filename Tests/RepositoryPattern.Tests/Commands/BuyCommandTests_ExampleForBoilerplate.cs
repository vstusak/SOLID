using Moq;
using NUnit.Framework;
using RepositoryPattern;
using RepositoryPattern.Commands;
using RepositoryPattern.Context;

namespace RepositoryPattern.Tests.Commands
{
    [TestFixture]
    public class BuyCommandTests_ExampleForBoilerplate : TestsBase
    {

        private Mock<Product> mockProduct;
        private Mock<IRepository<Product>> productRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            mockProduct = MockRepository.Create<Product>();
            productRepositoryMock = MockRepository.Create<IRepository<Product>>();
        }

        private BuyCommand CreateBuyCommand()
        {
            return new BuyCommand(
                mockProduct.Object,
                productRepositoryMock.Object);
        }

        [Test]
        public void CanExecute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var buyCommand = CreateBuyCommand();

            // Act
            var result = buyCommand.CanExecute();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Execute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var buyCommand = CreateBuyCommand();

            // Act
            buyCommand.Execute();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Undo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var buyCommand = CreateBuyCommand();

            // Act
            buyCommand.Undo();

            // Assert
            Assert.Fail();
        }
    }
}
