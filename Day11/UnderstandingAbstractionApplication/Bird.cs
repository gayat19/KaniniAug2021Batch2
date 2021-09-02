using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionApplication
{
    public class Bird : IFlying,IAnimal
    {
        public string Name { get; set; }
        public Bird()
        {
            Console.WriteLine("You have created a bird");
        }
        public Bird(string name)
        {
           Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Birds eat ....");
        }
        public void Fly()
        {
            Console.WriteLine("Fly fly fly");
        }

        public void Land()
        {
            Console.WriteLine("Stop flaping wings");
        }

        public void TakeOff()
        {
            Console.WriteLine("Falp wings fast");
        }

        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        }
    }
}
