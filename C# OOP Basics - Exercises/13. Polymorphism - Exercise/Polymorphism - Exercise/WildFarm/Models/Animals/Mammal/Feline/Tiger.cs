using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animal.Mammal.Feline
{
    public class Tiger : Feline
    {
        private const double increaseWeight = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        protected override double IncreaseWeight => increaseWeight;

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        protected override void ValidateFood(Food.Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                Throw(food);
            }
        }
    }
}
