using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionApplication
{
    public abstract class Dog
    {
        public void Eat()
        {
            Console.WriteLine("Birds eat ....");
        }

        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        }
        public abstract void Look();
    }
}
