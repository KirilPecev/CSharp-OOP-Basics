using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Factories;
using WildFarm.Models.Animal;
using WildFarm.Models.Animal.Bird;
using WildFarm.Models.Animal.Mammal;
using WildFarm.Models.Animal.Mammal.Feline;
using WildFarm.Models.Food;

namespace WildFarm.Core
{
    class Engine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                Animal animal = AnimalFactory.Create(input.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);

                Console.WriteLine(animal.ProduceSound());

                Food food = FoodFactory.Create(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                try
                {
                    animal.AddFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
