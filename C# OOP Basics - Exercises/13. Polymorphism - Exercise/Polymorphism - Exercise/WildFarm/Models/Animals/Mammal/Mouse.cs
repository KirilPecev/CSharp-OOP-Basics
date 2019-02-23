using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Mammal
{
    public class Mouse : Mammal
    {
        private const double increaseWeight = 0.10;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        protected override double IncreaseWeight => increaseWeight;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        protected override void ValidateFood(Food.Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                Throw(food);
            }
        }
    }
}
