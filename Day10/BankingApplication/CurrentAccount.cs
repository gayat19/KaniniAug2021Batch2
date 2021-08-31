using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class CurrentAccount:Account
    {
        public CurrentAccount()
        {
            AccountType = "Current";
        }

        public CurrentAccount(string accountNumber, string name, string phone, double balance) : base(accountNumber, name, phone, balance)
        {
            AccountType = "Current";
        }
        public override bool CheckBalanceStatus(double amount)
        {
            bool resut = false;
            if (Balance - amount > 1000)
            {
                Balance = Balance - amount;
                resut = true;
            }
            return resut;
        }
    }
}
