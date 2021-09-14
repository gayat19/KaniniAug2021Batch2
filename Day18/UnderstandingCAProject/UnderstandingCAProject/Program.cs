using System;

namespace UnderstandingCAProject
{
    class Program
    {
        string msg;
        private int _num;

        public Program()
        {
            Console.WriteLine();
        }
        public Program(int num)
        {
            _num = num;
        }
        static void Main(string[] args)
        {
            //new Program()._num = 100;
            Console.WriteLine("Hello World!");
        }
    }
}
