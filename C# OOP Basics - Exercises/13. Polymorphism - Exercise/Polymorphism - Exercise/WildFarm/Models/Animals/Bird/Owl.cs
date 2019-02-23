using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Bird
{
    public class Owl : Bird
    {
        private const double increaseWeight = 0.25;

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        protected override double IncreaseWeight => increaseWeight;

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        protected override void ValidateFood(Food.Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                this.Throw(food);
            }
        }
    }
}
