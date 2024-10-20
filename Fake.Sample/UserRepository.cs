using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Sample
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
           
        }

        public User GetUserById(int id)
        {
            return new User();
        }
    }
}
