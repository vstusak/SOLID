using Moq;
using NUnit.Framework;
using RepositoryPattern;
using RepositoryPattern.Commands;
using RepositoryPattern.Context;

namespace RepositoryPattern.Tests.Commands
{
    [TestFixture]
    public class BuyCommandTests
    {
        private MockRepository mockRepository;

        private Mock<Product> mockProduct;
        private Mock<IRepository<Product>> productRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockProduct = this.mockRepository.Create<Product>();
            this.productRepositoryMock = this.mockRepository.Create<IRepository<Product>>();
        }

        private BuyCommand CreateBuyCommand()
        {
            return new BuyCommand(
                this.mockProduct.Object,
                this.productRepositoryMock.Object);
        }

        [Test]
        public void CanExecute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var buyCommand = this.CreateBuyCommand();

            // Act
            var result = buyCommand.CanExecute();

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Execute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var buyCommand = this.CreateBuyCommand();

            // Act
            buyCommand.Execute();

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }

        [Test]
        public void Undo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var buyCommand = this.CreateBuyCommand();

            // Act
            buyCommand.Undo();

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
