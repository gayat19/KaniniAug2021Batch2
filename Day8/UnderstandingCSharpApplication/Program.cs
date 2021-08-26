using System;

namespace UnderstandingCSharpApplication
{
    class Program
    {
        void UnderstandingIf()
        {
            Console.WriteLine("Please ente a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1>100)
            {
                Console.WriteLine("Good");
                Console.WriteLine("Line 2");
            }
            else
                Console.WriteLine("Ok");
        }
        void UnderstandingSwitch()
        {
            Console.WriteLine("Please enter a day");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Monday": 
                    Console.WriteLine("Week start");
                    break;
                case "Tuesday": Console.WriteLine("Day2");
                    break;
                case "Wednesday":
                    Console.WriteLine("Mid week");
                    break;
                case "Thursday":
                    Console.WriteLine("Almost weekend");
                    break;
                case "Friday":
                    Console.WriteLine("Last working day");
                    break;
                case "Saturday":
                    Console.WriteLine("Weekend");
                    break;
                 case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }

        void UnderstandingForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of i is "+i);
            }
        }

        void UnderstandingWhileLoop()
        {
            int num = 10;
            while (num<100)
            {
                Console.WriteLine("The number is "+num);
                Console.WriteLine("Change the number");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }
        void UnderstandingDoWhileLoop()
        {
            int num;
            do
            {
                Console.WriteLine("Change the number");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number is " + num);
            } while (num < 100);
        }
        void UnderstandingCSharpFeatures()
        {
            int iNum1;//= int.MaxValue;
            //checked
            //{
            //    Console.WriteLine(iNum1);
            //    iNum1++;
            //    Console.WriteLine(iNum1);
            //}
            Console.WriteLine("Please enter a number");
            //iNum1 = Convert.ToInt32(Console.ReadLine());
            //bool res = int.TryParse(Console.ReadLine(), out iNum1);
            //if(res==true)
            //    Console.WriteLine("You have entered "+iNum1);
            //else
            //    Console.WriteLine("The number resulted in "+iNum1);
            //while (!int.TryParse(Console.ReadLine(), out iNum1))
            //{
            //    Console.WriteLine("Invalid entry. Please enter again");
            //}
            //Console.WriteLine("You have entered " + iNum1);
            int? iNum2 = 100;
            iNum1 = iNum2 ?? 10;
            Console.WriteLine($"The value is {iNum1}");
        }
        /// <summary>
        /// Gets a number form user in command prompt
        /// </summary>
        /// <returns>a integer entered by user</returns>
        int GetInputFromUser()
        {
            int iNum1;
            while (!int.TryParse(Console.ReadLine(), out iNum1))
            {
                Console.WriteLine("Invalid entry. Please enter again");
            }
            return iNum1;
        }

        /// <summary>
        /// A method which 10 takes numbers from user and finds teh average of those numbers whicha re divisible by seven
        /// </summary>
        void FindAverageOfNumbersDivisibleBy7()
        {
            Console.WriteLine("Finding the average of numbers divisible by 7");
            const int MAX = 10;
            int sum = 0,count = 0;
            Console.WriteLine("Please enter 10 numbers");
            for (int i = 0; i < MAX; i++)
            {
                int num = GetInputFromUser();
                if(num%7 ==0)
                {
                    sum += num;
                    count++;
                }
            }
            Console.WriteLine($"The average is {sum/count}"); 
        }
        void FindPrimeOrNot()
        {
            Console.WriteLine("Please enter the number for Prime or not ");
            int num = GetInputFromUser();
            bool flag = true;
            for (int i =2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                } 
            }
            if(flag)
                Console.WriteLine($"{num} is prime");
            else
                Console.WriteLine($"{num} is not prime");
        }
        void UnderstandingArray()
        {
            int[] numbers = { 12, 45, 78, 90, 23 };
            Console.WriteLine("The size of the array is "+numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("The number in index 5 is "+numbers[5]);
        }
        void LearningStringarray()
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Pease enter the {i+1} name");
                names[i] = Console.ReadLine();
            }
            for (int i = 0; i < names.Length-1; i++)
            {
                Console.Write(names[i]+" ,");
                
            }
            Console.WriteLine(names[names.Length-1]);
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //new Program().UnderstandingIf();
            //new Program().UnderstandingSwitch();
            //new Program().UnderstandingForLoop();
            //new Program().UnderstandingWhileLoop();
            //new Program().UnderstandingDoWhileLoop();
            //new Program().UnderstandingCSharpFeatures();
            //new Program().FindPrimeOrNot();
            //new Program().UnderstandingArray();
            new Program().LearningStringarray();
            Console.ReadKey();
        }
    }
}
