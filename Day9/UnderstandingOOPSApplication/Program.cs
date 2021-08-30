using System;

namespace UnderstandingOOPSApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ////SuperCycle motor = new SuperCycle();
            ////Console.WriteLine("Speed is "+motor.Speed);
            ////Console.WriteLine("Brand is " + motor.Brand);
            //Cycle cycle = new MotorCycle();
            //Console.WriteLine("Speed is "+cycle.Speed);
            ////Console.WriteLine(cycle.GetType().ToString());
            ////if(cycle.GetType().ToString() == "UnderstandingOOPSApplication.MotorCycle")
            ////{
            ////    ((MotorCycle)cycle).MotorRun();
            ////}
            //cycle.Run();
            //cycle = new MontainCycle();
            ////if (cycle.GetType().ToString() == "UnderstandingOOPSApplication.MontainCycle")
            ////{
            ////    ((MontainCycle)cycle).MontainRun();
            ////}
            //cycle.Run();
            //Console.WriteLine("speed is"+cycle.Speed);
            //Account account = new Account("Jack");
            //Console.WriteLine("The name of the account holder is "+account.Name);
            //account.CreateAccount(1100.2f, "Driving License");
            Account account1 = new Account();
            account1.CreateAccount(1000.2f);
            Account account2 = new Account();
            account2.CreateAccount(11000.0f);
            Account account3 = account1 + account2;
            Console.WriteLine("After ading the accounts "+account3.Balance);
            Console.ReadKey();
        }
    }
}
