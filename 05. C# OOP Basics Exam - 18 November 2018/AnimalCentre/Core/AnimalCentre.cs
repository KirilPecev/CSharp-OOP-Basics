namespace AnimalCentre.Core
{
    using Models.Animals;
    using Models.Contracts;
    using Models.Factories;
    using Models.Hotels;
    using Models.Procedures;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AnimalCentre
    {
        private Hotel hotel;
        private Procedure chip;
        private Procedure dentalCare;
        private Procedure fitness;
        private Procedure nailTrim;
        private Procedure play;
        private Procedure vaccinate;

        public AnimalCentre()
        {
            this.hotel = new Hotel();
            this.chip = new Chip();
            this.dentalCare = new DentalCare();
            this.fitness = new Fitness();
            this.nailTrim = new NailTrim();
            this.play = new Play();
            this.vaccinate = new Vaccinate();

        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            Animal animal = AnimalFactory.CreateAnimal(type, name, energy, happiness, procedureTime);

            this.hotel.Accommodate(animal);

            return $"Animal {animal.Name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            EnsureExist(name);

            this.chip.DoService(this.hotel.Animals[name], procedureTime);

            return $"{this.hotel.Animals[name].Name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            EnsureExist(name);

            this.vaccinate.DoService(this.hotel.Animals[name], procedureTime);

            return $"{this.hotel.Animals[name].Name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            EnsureExist(name);

            this.fitness.DoService(this.hotel.Animals[name], procedureTime);

            return $"{this.hotel.Animals[name].Name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            EnsureExist(name);

            this.play.DoService(this.hotel.Animals[name], procedureTime);

            return $"{this.hotel.Animals[name].Name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            EnsureExist(name);

            this.dentalCare.DoService(this.hotel.Animals[name], procedureTime);

            return $"{this.hotel.Animals[name].Name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            EnsureExist(name);

            this.nailTrim.DoService(this.hotel.Animals[name], procedureTime);

            return $"{this.hotel.Animals[name].Name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            EnsureExist(animalName);

            IAnimal animal = this.hotel.Animals[animalName];

            this.hotel.Adopt(animalName, owner);

            if (animal.IsChipped)
            {
                return $"{owner} adopted animal with chip";
            }
            else
            {
                return $"{owner} adopted animal without chip";
            }
        }

        public string History(string type)
        {
            var output = "";

            switch (type)
            {
                case "Chip":
                    output = this.chip.History();
                    break;
                case "DentalCare":
                    output = this.dentalCare.History();
                    break;
                case "Fitness":
                    output = this.fitness.History();
                    break;
                case "NailTrim":
                    output = this.nailTrim.History();
                    break;
                case "Play":
                    output = this.play.History();
                    break;
                case "Vaccinate":
                    output = this.vaccinate.History();
                    break;
            }

            return output;
        }

        private void EnsureExist(string name)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
        }

        public string End()
        {
            StringBuilder sb = new StringBuilder();

            List<string> animals = new List<string>();

            foreach (var owner in this.hotel.adoptedAnimals.OrderBy(x => x.Key))
            {
                sb.AppendLine($"--Owner: {owner.Key}");

                foreach (var animal in owner.Value.Reverse())
                {
                    animals.Add(animal.Name);
                }

                sb.AppendLine($"    - Adopted animals: {string.Join(" ", animals)}");
                animals.Clear();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
