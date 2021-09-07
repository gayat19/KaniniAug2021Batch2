using Microsoft.EntityFrameworkCore;
using MoreOnEFProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreOnEFProject
{
    class Program
    {
        CompanyContext context;
        public Program()
        {
            context = new CompanyContext();
        }
        void AddDepartment()
        {
            Department department1 = new Department {  Name = "HR" };
            Department department2 = new Department { Name = "Ops" };
            context.Departments.Add(department1);
            context.Departments.Add(department2);
            context.SaveChanges();
            Console.WriteLine("Department Created");
        }
        void PrintEmployeesDepartmentWise()
        {
            foreach (var item in context.Departments.Include(e=>e.employees))
            {
                Console.WriteLine("Department Number "+item.Number);
                Console.WriteLine("Department Name " + item.Name);
                foreach (var emp in item.employees)
                {
                    Console.WriteLine("----------Employee Id "+emp.EmployeeId);
                    Console.WriteLine("----------Employee Name " + emp.Name);
                    Console.WriteLine("----------Employee Age " + emp.Age);
                }
            }
        }
        void PrintEmployeesInADepartment()
        {
            Console.WriteLine("Please enter a department id");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Employee> employees = context.Employees.Where(e => e.DepartmentNumber == id).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine("----------Employee Id " + item.EmployeeId);
                Console.WriteLine("----------Employee Name " + item.Name);
                Console.WriteLine("----------Employee Age " + item.Age);
                Console.WriteLine("Department Number " + item.DepartmentNumber);
            }
        }
        void MoreLinq()
        {
            int[] arr = { 10, 20, 80, 8, 45, 78, 100 };
            //var numbers = from n in arr where n > 75 select n;
            var numbers = arr.Where(n => n > 75);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MoreLinq();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
