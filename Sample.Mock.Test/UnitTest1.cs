using Mock.Sample;
using Moq;

namespace Sample.Mock.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Notify_CallsSendEmail()
        {
            // Arrange
            var mockEmailService = new Mock<IEmailService>();
            var service = new NotificationService(mockEmailService.Object);

            // Act
            service.Notify("test1@example.com");

            // Assert: Verify that SendEmail was called once with specified parameters
            mockEmailService.Verify(es => es.SendEmail("test1@example.com", "Welcome!"), Times.Once);
        }
    }
}