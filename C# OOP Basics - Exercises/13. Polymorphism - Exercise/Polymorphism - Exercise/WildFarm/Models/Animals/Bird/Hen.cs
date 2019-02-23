using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Bird
{
    public class Hen : Bird
    {
        private const double increaseWeight = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        protected override double IncreaseWeight => increaseWeight;

        public override string ProduceSound()
        {
            return "Cluck";
        }

        protected override void ValidateFood(Food.Food food)
        {

        }
    }
}
