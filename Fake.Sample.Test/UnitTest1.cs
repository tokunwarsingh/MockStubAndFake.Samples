namespace Fake.Sample.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CreateUser_AddsUserToRepository()
        {
            // Arrange
            var fakeRepo = new FakeUserRepository();
            var service = new UserService(fakeRepo);

            // Act
            var user = service.CreateUser("Alice");

            // Assert
            Assert.NotNull(user);
            Assert.Equal(2, user.Id);
            Assert.Equal("Alice", user.Name);
            Assert.NotNull(fakeRepo.GetUserById(1)); // Check if user was actually added
        }
    }
}