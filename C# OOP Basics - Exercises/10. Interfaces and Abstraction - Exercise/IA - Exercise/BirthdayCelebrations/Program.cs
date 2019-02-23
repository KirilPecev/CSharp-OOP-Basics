using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArgs = input.Split();

                string date = "";
                if (inputArgs[0] == "Citizen")
                {
                    date = inputArgs[4];
                }
                else if (inputArgs[0] == "Pet")
                {
                    date = inputArgs[2];
                }

                citizens.Add(new Citizen()
                {
                    Date = date
                });

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                if (citizen.Date.EndsWith(input))
                {
                    Console.WriteLine(citizen.Date);
                }
            }

        }
    }
}
