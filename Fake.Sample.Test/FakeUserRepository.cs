using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Sample.Test
{
    internal class FakeUserRepository : IUserRepository
    {
        private List<User> _users = new List<User>();        

        public User GetUserById(int id)
        {
            _users = GetFakeuserList();
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void AddUser(User user)
        {
            _users = GetFakeuserList();
            _users.Add(user);
        }

        private List<User>  GetFakeuserList()
        {
            _users.Add(new User { Id = 1, Name = "Alice" });
            //_users.Add(new User { Id = 2, Name = "Test2" });
            return _users;
        }

        /*
        private List<User> GenerateFakeUsers(int count)
        {
        var faker = new Bogus.Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)  // Incrementing ID
            .RuleFor(u => u.FirstName, f => f.Name.FirstName());

        return faker.Generate(count);
        }
        */
    }
}
