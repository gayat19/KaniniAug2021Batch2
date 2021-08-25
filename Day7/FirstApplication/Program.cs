using System;

namespace FirstApplication
{
    class Program
    {
        void Add()
        {
            int num1, num2;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add();
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello from G3");
            //int num1 = int.MaxValue;
            //Console.WriteLine("The value of num1 is "+num1);
            //num1 = num1 + 1;
            //Console.WriteLine("The value of num1 is after adding is  " + num1);
            //Mobile obj = new Mobile();
            //obj.Name = "Oppo";
            //obj.Price = 12345.23f;
            //obj.Speed = 123;
            //obj.Call();
            //obj.PrintAbout();
            //Mobile nokia = new Mobile();
            //nokia.Name = "Nokia";
            //nokia.Price = 11000f;
            //nokia.PrintAbout();

            Console.ReadKey();
        }
    }
}
