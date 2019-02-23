using System;
using System.Collections.Generic;

namespace BorderControl
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

                if (inputArgs.Length == 3)
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];
                    citizens.Add(new Citizen(name, age, id));
                }
                else
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];
                    citizens.Add(new Citizen(model, id));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                if (citizen.Id.EndsWith(input))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
