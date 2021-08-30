using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    public class Account
    {
        public float Balance { get; set; }
        public bool IdProof { get; set; }
        public string Name { get; set; }
        //Default Constructor
        public Account()
        {
            Console.WriteLine("Default constuctor");
        }
        public Account(string name)
        {
            Name = name;
        }
       
        /// <summary>
        /// Creates a account for the user
        /// </summary>
        /// <param name="amount">The minimum balance that will be present</param>
        public void CreateAccount(float amount)
        {
            Balance = amount;
            IdProof = false;
        }
        /// <summary>
        /// Creates a account for the user
        /// </summary>
        /// <param name="amount">The minimum balance that will be present</param>
        /// <param name="idProof">The Id Proof for opening teh account</param>
        public void CreateAccount(float amount,string idProof)
        {
            Balance = amount;
            Console.WriteLine("The Id Proof is "+idProof);
            IdProof = true;
        }
        public static Account operator +(Account a1,Account a2)
        {
            Account account = new Account();
            account.Balance = a1.Balance + a2.Balance;
            return account;
        }
    }
}
