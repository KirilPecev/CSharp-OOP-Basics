using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Core
{
    class Engine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            string type = Console.ReadLine();
            while (type != "Beast!")
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    AddAnimal(animals, info, type);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                type = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static void AddAnimal(List<Animal> animals, string[] info, string type)
        {
            switch (type)
            {
                case "Dog":
                    animals.Add(new Dog(info[0], int.Parse(info[1]), info[2]));
                    break;
                case "Cat":
                    animals.Add(new Cat(info[0], int.Parse(info[1]), info[2]));
                    break;
                case "Frog":
                    animals.Add(new Frog(info[0], int.Parse(info[1]), info[2]));
                    break;
                case "Kitten":
                    animals.Add(new Kitten(info[0], int.Parse(info[1])));
                    break;
                case "Tomcat":
                    animals.Add(new Tomcat(info[0], int.Parse(info[1])));
                    break;
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
