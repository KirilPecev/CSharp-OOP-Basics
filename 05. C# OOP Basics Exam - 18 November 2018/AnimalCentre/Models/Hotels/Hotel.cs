namespace AnimalCentre.Models.Hotels
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hotel : IHotel
    {
        private const int capacity = 10;
        private Dictionary<string, IAnimal> animals;
        public Dictionary<string, Stack<IAnimal>> adoptedAnimals;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
            this.adoptedAnimals = new Dictionary<string, Stack<IAnimal>>();
        }

        public IReadOnlyDictionary<string, IAnimal> Animals { get { return this.animals.ToDictionary(pair => pair.Key, pair => pair.Value); } }

        public void Accommodate(IAnimal animal)
        {
            if (capacity == this.Animals.Count)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (this.Animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            this.animals.Add(animal.Name, animal);
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.Animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            this.Animals[animalName].Owner = owner;
            this.Animals[animalName].IsAdopt = true;

            if (!this.adoptedAnimals.ContainsKey(owner))
            {
                this.adoptedAnimals.Add(owner, new Stack<IAnimal>());
            }

            this.adoptedAnimals[owner].Push(this.Animals[animalName]);

            this.animals.Remove(animalName);
        }
    }
}
