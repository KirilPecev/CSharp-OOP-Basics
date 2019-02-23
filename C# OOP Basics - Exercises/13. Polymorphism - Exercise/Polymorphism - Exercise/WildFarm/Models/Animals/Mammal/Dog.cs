using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Mammal
{
    public class Dog : Mammal
    {
        private const double increaseWeight = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        protected override double IncreaseWeight => increaseWeight;

        public override string ProduceSound()
        {
            return "Woof!";
        }

        protected override void ValidateFood(Food.Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Meat))
            {
                Throw(food);
            }
        }
    }
}
