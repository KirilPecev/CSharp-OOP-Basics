using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal.Mammal
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            if (this.GetType().Name == "Dog" || this.GetType().Name == "Mouse")
            {
                return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
            }

            return base.ToString();
        }
    }
}
