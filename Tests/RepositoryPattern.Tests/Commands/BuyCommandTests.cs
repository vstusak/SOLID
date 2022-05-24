using Moq;
using NUnit.Framework;
using RepositoryPattern;
using RepositoryPattern.Commands;
using RepositoryPattern.Context;
using System;

namespace RepositoryPattern.Tests.Commands
{
    [TestFixture]
    public class BuyCommandTests : TestsBase
    {
        private Mock<IRepository<Product>> mockRepository;

        [SetUp]
        public void SetUp()
        {
            mockRepository = MockRepository.Create<IRepository<Product>>();
        }

        private BuyCommand CreateBuyCommand()
        {
            return new BuyCommand(
                new Product() { },
                mockRepository.Object);
        }

        //Test for quantity=0 needed as well
        [Test]
        public void CanExecute_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var product = new Product { Quantity = 1 };

            var buyCommand = CreateBuyCommand();
            mockRepository.Setup(mr => mr.Get(It.IsAny<Guid>())).Returns(product);


            // Act
            var result = buyCommand.CanExecute();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Execute_DecreasesQuantity()
        {
            // Arrange
            var product = new Product { Quantity = 1 };
            var buyCommand = CreateBuyCommand();
            mockRepository.Setup(mr => mr.Update(It.IsAny<Product>())).Returns(product);
            mockRepository.Setup(mr => mr.Get(It.IsAny<Guid>())).Returns(product);

            // Act
            buyCommand.Execute();

            // Assert
            Assert.AreEqual(0, product.Quantity);
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
