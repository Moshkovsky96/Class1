using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public bool Check(string email, string password)
        {

            if (email == Email && password == Password)
            
                
                return true;
            
            else
                return false;
        
        }

    }
}
