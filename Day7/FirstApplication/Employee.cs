using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime DOB { get; set; }
        void GetEmployeeDataFromUser()
        {
            Console.WriteLine("Please enter the employee Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee salary");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the date of birth");
            DOB = Convert.ToDateTime(Console.ReadLine());
        }
        void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id "+Id);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee Salary " + Salary);
            Console.WriteLine("Employee DOB " + DOB);
        }
        static void Main(string[] arr)
        {
            Employee emp1 = new Employee();
            emp1.GetEmployeeDataFromUser();
            emp1.PrintEmployeeDetails();
            Console.WriteLine("Employee class");
            Console.ReadKey();
        }
    }
}
