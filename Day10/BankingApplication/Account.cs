using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Balance = 5000;
        }

        public Account(string accountNumber, string name, string phone, double balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Phone = phone;
            Balance = balance;
        }
        public void GetAccountDetailsFromUser()
        {
            Console.WriteLine("Please enter the account number");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Please enter the account holder's name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the contact phone number");
            Phone = Console.ReadLine();
            Console.WriteLine("Please enter the initial balance");
            Balance = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Account number : " + AccountNumber
                +"\nAccount Type : "+AccountType
                + "\nAccount holder's name : " + Name
                + "\nCurrent Balance : " + Balance
                + "\nContact number : " + Phone;
        }
        public virtual bool CheckBalanceStatus(double amount)
        {
            bool resut = false;
            return resut;
        }
    }

}
