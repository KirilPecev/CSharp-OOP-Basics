using Ferrari.Cars;
using Ferrari.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari.Core
{
    class Engine
    {
        public void Run()
        {
            string name = Console.ReadLine();

            ICarable ferrari = new ModelFerrari("488-Spider", name);

            Console.WriteLine(ferrari);
        }
    }
}
