using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class UI
    {
        public void Start()
        {


            Console.WriteLine("Введите Email");
            string email = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            BankService checkUsers = new BankService();
            User result = checkUsers.CheckUsers( email, password);
            if (result != null)
            {
                Console.WriteLine("Авторизация успешна");
                int operation = ShowOperations();
                ChooseOperation(operation, result);
            }
            else
            {
                Console.WriteLine("Авторизация не успешна");
            }
        }
        public int ShowOperations()
        {
            Console.WriteLine("1. Создать счет");
            Console.WriteLine("2. Пополнить счет");
            Console.WriteLine("3. Снять средства");
            Console.WriteLine("4. Переслать средства");
            Console.WriteLine("5. Проверить средства на счете");
            Console.WriteLine("6. Взять кредит");
            Console.WriteLine("7. Оформить депозит");
            Console.WriteLine("8. Получить номер банка");
            int operation = Convert.ToInt32(Console.ReadLine());
            return operation ;
             
        }
        public void ChooseOperation (int operation, User user )
        {
            BankService bankService = new BankService();

            switch (operation)
            {
                case 1:
                    bankService.CreateAccount();
                    break;
                case 2:
                    Console.WriteLine("На сколько вы хотите пополнить счет?");
                    double moneyAmount = Convert.ToDouble(Console.ReadLine());
                    double rechargeBalance = bankService.RechargeBalance(user, moneyAmount);
                    Console.WriteLine(rechargeBalance);
                    break;
                case 3:
                    Console.WriteLine("Сколько средств вы хотите снять?");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    double withdrawMoney = bankService.WithdrawMoney(user, withdraw);
                    if (withdrawMoney < 0)
                        Console.WriteLine("Недостаточно средств");
                    else 
                        Console.WriteLine(withdrawMoney);
                    break;

            }
        }


        
    }
}
