using System;

namespace ExceptionExampleApplication
{
    class Program
    {

        int Check()
        {
            int num1 = 100;
            int num2 = 0;
            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Always");
            }
            Console.WriteLine("All done");
            return 0;
        }
        static void Main(string[] args)
        {
            //Company company = new Company();
            //company.AddEmployees();
            //company.PrintEmployees();
            new Program().Check();
            Console.ReadKey();
        }
    }
}
