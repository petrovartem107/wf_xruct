using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_abstract
{
    abstract class EngineMachine
    {
        public abstract void Move();
        private int moshnost;

        public void SetMosh(int mosh)
        {
            moshnost = mosh;
        }
    }


    class Car : EngineMachine
    {
        public override void Move()
        {
            Console.WriteLine("МАшинка поехала");
        }
    }
    class Bus : EngineMachine
    {
        public override void Move()
        {
            Console.WriteLine("Автобус поехала");
        }
    }
    class Traktor : EngineMachine
    {
        public override void Move()
        {
            Console.WriteLine("Автобус поехала");
        }
    }
}
