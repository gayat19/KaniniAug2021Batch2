using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Mobile
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public void Call()
        {
            string phone;
            Console.WriteLine("Please enter the phone number to make a call");
            phone = Console.ReadLine();
            Console.WriteLine("Making Call to "+phone);
        }
        public void PrintAbout()
        {
            Console.WriteLine("Name of the mobile is "+Name);
            Console.WriteLine("Price of the mobile is "+Price);
        }
    }
}
