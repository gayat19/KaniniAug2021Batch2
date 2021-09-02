using System;

namespace AccessSpecifierExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            C1 c = null;
            c.num1 = 100+20;
            Console.WriteLine(c.num1);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
