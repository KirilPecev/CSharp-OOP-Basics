using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Mammal.Feline
{
    public class Cat : Feline
    {
        private const double increaseWeight = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        protected override double IncreaseWeight => increaseWeight;

        public override string ProduceSound()
        {
            return "Meow";
        }

        protected override void ValidateFood(Food.Food food)
        {
            string type = food.GetType().Name;

            if (type != nameof(Vegetable) && type != nameof(Meat))
            {
                Throw(food);
            }
        }
    }
}
