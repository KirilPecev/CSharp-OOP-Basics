using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] foods = Console.ReadLine().Split();

            Gandalf gandalf = new Gandalf();
            gandalf.TakeFood(foods);
            Console.WriteLine(gandalf);
        }
    }
}
