using System;

namespace UnderstandingAbstractionApplication
{
    class Program
    {
        void VisitForest(IAnimal animal)
        {
            animal.Eat();
            animal.Sleep();
        }
        void SkyShow(IFlying flying)
        {
            flying.TakeOff();
            flying.Fly();
            flying.Land();
        }
        static void Main(string[] args)
        {
            Bird bird = new Bird("Parrot");
            Program program = new Program();
            program.SkyShow(bird);
            program.VisitForest(bird);
            Dog dog = new GreatDane();
            Console.ReadKey();
        }
    }
}
