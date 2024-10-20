using Moq;

namespace Stub.Sample.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Verify_ProcessOrder_ReturnsOrder()
        {
            // Arrange
            var stubRepo = new Mock<IOrderRepository>();
            //stubRepo.Setup(repo => repo.GetOrderById(1)).Returns(new Order { Id = 1, ProductName = "Laptop" });
            stubRepo.Setup(repo => repo.GetOrderById(It.IsAny<int>())).Returns(new Order { Id = 1, ProductName = "Laptop" });

            var service = new OrderService(stubRepo.Object);

            // Act
            var result = service.ProcessOrder(2);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Laptop", result.ProductName);
        }
    }
}