using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class BankService
    {
        
        public User CheckUsers(string email, string password)
        {
            Database database = new Database();
            User[] users = database.GetAllUsers();


            foreach (var item in users)
            {
               bool result = item.Check(email, password);
                if (result == true)
                    return item;
                

            }
            return null;
           

        }
        public  void CreateAccount()

        {

        }
        public double RechargeBalance(User user,double moneyAmount)
        {
            user.Balance += moneyAmount;
            return user.Balance;
        }
        public double WithdrawMoney (User user, double withdrawMoney)
        {
            user.Balance -= withdrawMoney;
            return user.Balance;

        }

    }
}
