using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    public class Cycle
    {
        public int Speed { get; set; }

        public virtual void Run()
        {
            Console.WriteLine($"Cycle Runs in {Speed} speed");
        }

    }
    public class MontainCycle: Cycle
    {
        public MontainCycle()
        {
            Speed = 40;
            Console.WriteLine("Can climb montains");
        }
        public void MontainRun()
        {
            Console.WriteLine($"Montain Cycle Runs in {Speed} speed");
        }
        public override void Run()
        {
            Console.WriteLine($"Montain Cycle Runs in {Speed} speed");
        }
    }
    public class MotorCycle : Cycle
    {
        public string Brand { get; set; }
        public MotorCycle()
        {
            Console.WriteLine("has motor rrrrrrrrrrrrrrrrr");
            Speed = 60;
        }
        public void MotorRun()
        {
            Console.WriteLine($"MotorCycle Runs in {Speed} speed");
        }
        public override void Run()
        {
            Console.WriteLine($"MotorCycle Runs in {Speed} speed");
        }

    }
    public class SuperCycle:MotorCycle
    {
        public SuperCycle()
        {
            Speed = 90;
            Brand = "XYZ";
        }
    }
}
