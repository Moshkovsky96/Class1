using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Startup
    {
        public void Start()
        {
            User user1 = new User() { Email = "programist", Password = "qwerty12345", Id = "529" };
            User user2 = new User() { Email = "programmer", Password = "programmer", Id = "530" };
            User user3 = new User() { Email = "vlad96", Password = "vlad96", Id = "531" };

            Console.WriteLine("Введите Email");
            string email = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            User[] users = new User[] { user1, user2, user3 };

            CheckUsers(email, password,users);
        }
        public void CheckUsers(string email, string password, User[] users)
        {
            bool result = false;

            foreach (var item in users)
            {
                result = item.Check(email, password);

                if (result == true)
                {
                    Console.WriteLine("Авторизация успешна");
                    break;
                }
            }
            if (!result)
            {
                Console.WriteLine("Авторизация не успешна");

            }

        }

    }
}
