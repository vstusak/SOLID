using Moq;
using RepositoryPattern.Commands;
using RepositoryPattern.Context;
using System;
using NUnit.Framework;

namespace RepositoryPattern.Tests
{
    [TestFixture]
    public class BuyCommandTestsMockRepositoryTests
    {
        public MockRepository MockRepository { get; set; }
        private Mock<IRepository<Product>> productRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            MockRepository = new MockRepository(MockBehavior.Strict);
            productRepositoryMock = MockRepository.Create<IRepository<Product>>();
        }

        [TearDown]
        public void TearDown()
        {
            MockRepository.VerifyAll(); //Check everything (mocks) was setup
        }

        [TestCase(9, 8)]
        [TestCase(1, 0)]
        public void Execute_DefaultQuantity_QuantityDecreasedByOne(int defaultQuantity, int expectedQuantity)
        {
            //Arrange
            var product = new Product { Quantity = defaultQuantity };
            productRepositoryMock.Setup(pr => pr.Get(It.IsAny<Guid>())).Returns(product);
            productRepositoryMock.Setup(pr => pr.Update(It.IsAny<Product>())).Returns(product);

            var buyCommand = new BuyCommand(product, productRepositoryMock.Object);

            //Act
            buyCommand.Execute();

            //Assert
            Assert.AreEqual(expectedQuantity, product.Quantity);

            //Should be in a separated test
            productRepositoryMock.Verify(mrp => mrp.Update(It.IsAny<Product>()), Times.Exactly(1));
        }

        [TestCase(true, 1)]
        [TestCase(false, 0)]
        public void CanExecute(bool expectedResult, int defaultQuantity)
        {
            //Arrange
            var product = new Product { Quantity = defaultQuantity };
            var buyCommand = new BuyCommand(product, productRepositoryMock.Object);
            productRepositoryMock.Setup(pr => pr.Get(It.IsAny<Guid>())).Returns(product);

            //Act
            var result = buyCommand.CanExecute();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(8, 9)]
        [TestCase(0, 1)]
        public void Undo_DefaultQuantity_QuantityIncreasedByOne(int defaultQuantity, int expectedQuantity)
        {
            //Arrange
            var product = new Product { Quantity = defaultQuantity };
            productRepositoryMock.Setup(pr => pr.Get(It.IsAny<Guid>())).Returns(product);
            productRepositoryMock.Setup(pr => pr.Update(It.IsAny<Product>())).Returns(product);

            var buyCommand = new BuyCommand(product, productRepositoryMock.Object);

            //Act
            buyCommand.Undo();

            //Assert
            Assert.AreEqual(expectedQuantity, product.Quantity);

            //Should be in a separated test
            productRepositoryMock.Verify(mrp => mrp.Update(It.IsAny<Product>()), Times.Exactly(1));
        }
    }
}