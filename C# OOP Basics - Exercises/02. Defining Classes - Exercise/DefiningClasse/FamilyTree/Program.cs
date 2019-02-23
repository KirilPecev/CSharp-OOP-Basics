using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            List<string> relationships = new List<string>();
            string searchedPerson = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (!input.Contains("-"))
                {
                    AddMember(allPersons, input);
                }
                else
                {
                    relationships.Add(input);
                }

                input = Console.ReadLine();
            }

            foreach (var line in relationships)
            {
                string[] lineArgs = line.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                Person parent = GetPerson(allPersons, lineArgs[0]);
                Person child = GetPerson(allPersons, lineArgs[1]);

                parent.Children.Add(child);
                child.Parents.Add(parent);
            }

            Print(allPersons, searchedPerson);
        }

        private static void Print(List<Person> allPersons, string searchedPerson)
        {
            Person person = allPersons.FirstOrDefault(x => x.Name == searchedPerson);
            if (searchedPerson.Contains("/"))
            {
                person = allPersons.FirstOrDefault(x => x.Birthday == searchedPerson);
            }
            
            Console.WriteLine($"{person.Name} {person.Birthday}");
            Console.WriteLine("Parents:");
            person.Parents.ForEach(x => Console.WriteLine($"{x.Name} {x.Birthday}"));
            Console.WriteLine("Children:");
            person.Children.ForEach(x => Console.WriteLine($"{x.Name} {x.Birthday}"));
        }

        private static Person GetPerson(List<Person> allPersons, string input)
        {
            if (input.Contains("/"))
            {
                return allPersons.FirstOrDefault(x => x.Birthday == input);
            }

            return allPersons.FirstOrDefault(x => x.Name == input);
        }

        private static void AddMember(List<Person> allPersons, string input)
        {
            string[] inputArgs = input.Split();
            string name = inputArgs[0] + " " + inputArgs[1];
            string birthday = inputArgs[2];

            allPersons.Add(new Person(name, birthday));
        }
    }
}
