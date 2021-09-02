using System;
using System.Collections;

namespace UnderstandingCollectionApplication
{
    class Program
    {
        ArrayList myArray;
        public Program()
        {
            myArray = new ArrayList();
        }
        void AddElementsToArray()
        {
            int num = 0;
            Console.WriteLine("Please enter numbers. If you want to stop enter a negative number");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                myArray.Add(num);
                //myArray.Add(Console.ReadLine()); 
            } while (num>0);
        }
        private void CalculateSum()
        {
            int sum = 0;
            foreach (var item in myArray)
            {
                int num = Convert.ToInt32(item);
                if (num > 0)
                    sum += num;
            }
            Console.WriteLine($"The sum is {sum}");
        }
        private void PrintArray()
        {
            myArray.Add("1oo");
            //for (int i = 0; i < myArray.Count; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.AddElementsToArray();
            //program.PrintArray();
            //program.CalculateSum();
            WorkingWithLIst working = new WorkingWithLIst();
            working.MoreOnEqual();
            Console.ReadKey();
        }

        
    }
}
