using System;

namespace BankingApplication
{
    class Program
    {
        Bank bank;
        public Program()
        {
            bank = new Bank();
        }
        void PrintMenu()
        {
            int iChoice = 0;
            do
            {
                PrintMenuList();
                iChoice = Convert.ToInt32(Console.ReadLine());
                switch (iChoice)
                {
                    case 0:
                        Console.WriteLine("You have selected to exit. Bye....");
                        break;
                    case 1:
                        bank.AddAccounts();
                        break;
                    case 2:
                        bank.PrintAllAccountDetails();
                        break;
                    case 3:
                        bank.PrintAccountByNumber();
                        break;
                    case 4:
                        bank.Transact();
                        break;
                    case 5:
                        bank.PrintAllTranscations();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            } while (iChoice!=0);
        }
        void PrintMenuList()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create Accounts");
            Console.WriteLine("2. Print all account's details");
            Console.WriteLine("3. Print details of an account");
            Console.WriteLine("4. Transact");
            Console.WriteLine("5. Print all transaction details");

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}
