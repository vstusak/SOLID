using Moq;
using RepositoryPattern.Commands;
using RepositoryPattern.Context;
using System;
using Xunit;

namespace RepositoryPattern.Tests
{
    public class BuyCommandTests
    {
        [Theory]
        [InlineData(9, 8)]
        [InlineData(1, 0)]
        public void Execute_Decreases_ProductQuantity(int defaultQuantity, int expectedQuantity)
        {
            //Arrange
            var product = new Product { Quantity = defaultQuantity };
            var productRepositoryMock = new Mock<IRepository<Product>>(MockBehavior.Strict);
            productRepositoryMock.Setup(pr => pr.Get(It.IsAny<Guid>())).Returns(product);
            productRepositoryMock.Setup(pr => pr.Update(It.IsAny<Product>())).Returns(product);

            var buyCommand = new BuyCommand(product, productRepositoryMock.Object);

            //productRepository.Setup(x => x.Get(It.IsAny<string>())).Returns(product);
            //Act

            buyCommand.Execute();


            //Assert
            Assert.Equal(expectedQuantity, product.Quantity);


            asdproductRepositoryMock.Verify(mrp => mrp.Update(It.IsAny<Product>()), Times.Exactly(1));
        }


        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 0)]
        public void CanExecute(bool expectedResult, int defaultQuantity)
        {
            //Arrange
            var product = new Product { Quantity = defaultQuantity };
            var productRepositoryMock = new Mock<IRepository<Product>>(MockBehavior.Strict);
            var buyCommand = new BuyCommand(product, productRepositoryMock.Object);
            productRepositoryMock.Setup(pr => pr.Get(It.IsAny<Guid>())).Returns(product);

            //Act

            var result = buyCommand.CanExecute();
            //Assert

            Assert.Equal(expectedResult, result);
        }
    }
}