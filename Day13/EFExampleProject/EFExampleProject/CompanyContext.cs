﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExampleProject
{
    public class CompanyContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial catalog=dbCompanyEFCF");
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding my table-Providing initial records
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                Id = 101,
                Name = "Jack",
                Age = 23
            });
        }
    }
}
