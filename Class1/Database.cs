using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Database
    {
       
            User user1 = new User() { Email = "programist", Password = "qwerty12345", Id = "529", Balance = 500 };
            User user2 = new User() { Email = "programmer", Password = "programmer", Id = "530", Balance = 231 };
            User user3 = new User() { Email = "vlad96", Password = "vlad96", Id = "531", Balance = 1100 };

        public User[] GetAllUsers()
        {
            User[] users = new User[] { user1, user2, user3 };
            return users;

        }





    }
}
