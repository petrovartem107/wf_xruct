using System;

namespace Interface_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMover car2 = new Car2();
            car2.Move();

            EngineMachine machine = new Bus();
            machine.Move();
        }
    }

}
