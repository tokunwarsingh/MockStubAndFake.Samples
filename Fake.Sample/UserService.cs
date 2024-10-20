using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Sample
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateUser(string name)
        {
            var user = new User { Id = _userRepository.GetUserById(1)?.Id + 1 ?? 1, Name = name };
            _userRepository.AddUser(user);
            return user;
        }
    }
}
