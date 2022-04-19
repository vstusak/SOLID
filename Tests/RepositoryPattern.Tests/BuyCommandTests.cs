using Moq;
using RepositoryPattern.Commands;
using RepositoryPattern.Context;
using Xunit;

namespace RepositoryPattern.Tests
{
    public class BuyCommandTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var product = new Product();
            var productRepositoryMock = new Mock<IRepository<Product>>();
            var buyCommand = new BuyCommand(product, productRepositoryMock.Object);

            //productRepository.Setup(x => x.Get(It.IsAny<string>())).Returns(product);
            //Act
            buyCommand.Execute();

            //Assert

        }
    }
}