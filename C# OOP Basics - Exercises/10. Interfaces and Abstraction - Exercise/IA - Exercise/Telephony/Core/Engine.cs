using System;
using Telephony.Smartphone;
namespace Telephony.Core
{
    class Engine
    {
        public void Run()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            Smartphone.Smartphone smartphone = new Smartphone.Smartphone();
            foreach (var numeber in numbers)
            {
                try
                {
                    smartphone.Number = numeber;
                    Console.WriteLine(smartphone.Calling());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var site in sites)
            {
                try
                {
                    smartphone.Site = site;
                    Console.WriteLine(smartphone.Browsing());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
