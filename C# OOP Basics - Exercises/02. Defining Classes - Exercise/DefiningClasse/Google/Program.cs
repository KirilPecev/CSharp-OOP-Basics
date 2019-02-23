using System;
using System.Collections.Generic;

namespace Google
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> info = new Dictionary<string, Person>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string infoType = tokens[1];

                switch (infoType)
                {
                    case "company":
                        AddCompany(info, tokens);
                        break;
                    case "pokemon":
                        AddPokemon(info, tokens);
                        break;
                    case "parents":
                        AddParents(info, tokens);
                        break;
                    case "children":
                        AddChildren(info, tokens);
                        break;
                    case "car":
                        AddCar(info, tokens);
                        break;
                }


                input = Console.ReadLine();
            }

            string nameForResearch = Console.ReadLine();

            var p = info[nameForResearch];

            Console.WriteLine(nameForResearch);

            Print(p);
        }

        private static void Print(Person p)
        {
            Console.WriteLine("Company:");
            if (p.Company != null)
            {
                Console.WriteLine($"{p.Company.ToString()}");
            }
            Console.WriteLine("Car:");
            if (p.Car != null)
            {
                Console.WriteLine($"{p.Car.ToString()}");
            }
            Console.WriteLine("Pokemon:");
            if (p.Pokemons != null)
            {
                p.Pokemons.ForEach(x => Console.Write($"{x.ToString()}"));
            }
            Console.WriteLine("Parents:");
            if (p.Parents != null)
            {
                p.Parents.ForEach(x => Console.Write($"{x.ToString()}"));
            }
            Console.WriteLine("Children:");
            if (p.Children != null)
            {
                p.Children.ForEach(x => Console.Write($"{x.ToString()}"));
            }
        }

        private static void AddChildren(Dictionary<string, Person> info, string[] tokens)
        {
            string name = tokens[0];
            string childName = tokens[2];
            string childBirthday = tokens[3];

            if (!info.ContainsKey(name))
            {
                info.Add(name, new Person());
            }

            info[name].Children.Add(new Children(childName, childBirthday));
        }

        private static void AddParents(Dictionary<string, Person> info, string[] tokens)
        {
            string name = tokens[0];
            string parentName = tokens[2];
            string parentBirthday = tokens[3];

            if (!info.ContainsKey(name))
            {
                info.Add(name, new Person());
            }

            info[name].Parents.Add(new Parents(parentName, parentBirthday));
        }

        private static void AddPokemon(Dictionary<string, Person> info, string[] tokens)
        {
            string name = tokens[0];
            string pokemonName = tokens[2];
            string pokemonType = tokens[3];

            if (!info.ContainsKey(name))
            {
                info.Add(name, new Person());
                info[name].AddPokemon(new Pokemon(pokemonName, pokemonType));
            }
            else
            {
                info[name].AddPokemon(new Pokemon(pokemonName, pokemonType));
            }
        }

        private static void AddCar(Dictionary<string, Person> info, string[] tokens)
        {
            string name = tokens[0];
            string model = tokens[2];
            string speed = tokens[3];

            if (!info.ContainsKey(name))
            {
                info.Add(name, new Person());
            }

            info[name].Car = new Car(model, speed);
        }

        private static void AddCompany(Dictionary<string, Person> info, string[] tokens)
        {
            string name = tokens[0];
            string companyName = tokens[2];
            string department = tokens[3];
            double salary = double.Parse(tokens[4]);

            if (!info.ContainsKey(name))
            {
                info.Add(name, new Person());
            }

            info[name].Company = new Company(companyName, department, salary);
        }
    }
}
