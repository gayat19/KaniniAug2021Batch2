﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEFProject.Models
{
    public class Department
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> employees { get; set; }
    }
}
