using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_abstract
{
    interface IMover
    {
        void Move();
    }

    class Car2 : IMover
    {
        public void Move()
        {
            Console.WriteLine("МАшинка поехала");
        }


    }

    class Horse : IMover
    {
        public void Move()
        {
            Console.WriteLine("Лошадка побежала");
        }
    }

    class Sheap : IMover
    {
        public void Move()
        {
            Console.WriteLine("Лодка поплыла");
        }
    }
}
