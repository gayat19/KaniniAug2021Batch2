using System;
using System.Collections.Generic;
using System.Linq;

namespace EFExampleProject
{
    class Program
    {
        CompanyContext context;
        public Program()
        {
            context = new CompanyContext();
        }
        void GetAllEmployeesFromDatabase()
        {
            List<Employee> employees = context.Employees.ToList();
            foreach (var item in context.Employees)
            {
                Console.WriteLine("Employee Id "+item.Id);
                Console.WriteLine("Employee Name " + item.Name);
                Console.WriteLine("Employee Age " + item.Age);
                Console.WriteLine("------------------------------");
            }
        }
        void AddEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Please enter the employee name");
            employee.Name =  Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddEmployee();
            program.GetAllEmployeesFromDatabase();
            Console.ReadKey();

        }
    }
}
