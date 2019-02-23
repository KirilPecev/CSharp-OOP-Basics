using System;
using System.Collections.Generic;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public abstract string ProduceSound();

        protected abstract double IncreaseWeight { get; }

        public void AddFood(Food.Food food)
        {
            ValidateFood(food);

            this.FoodEaten += food.Quantity;

            this.Weight += IncreaseWeight * food.Quantity;
        }

        protected abstract void ValidateFood(Food.Food food);

        protected void Throw(Food.Food food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
