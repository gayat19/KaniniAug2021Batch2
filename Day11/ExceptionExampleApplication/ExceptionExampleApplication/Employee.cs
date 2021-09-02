using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExampleApplication
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public override string ToString()
        {
            return Id +"   "+Name;
        }
    }
}
