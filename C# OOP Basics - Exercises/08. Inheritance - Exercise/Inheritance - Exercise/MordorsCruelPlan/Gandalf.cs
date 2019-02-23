using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MordorsCruelPlan
{
    class Gandalf
    {
        private List<Food.Food> foods;
        private Mood.Mood mood;

        public Gandalf()
        {
            this.foods = new List<Food.Food>();
        }

        public void TakeFood(string[] foods)
        {
            foreach (var food in foods)
            {
                Food.Food current = FoodFactory.GenerateFood(food);
                this.foods.Add(current);
            }

            CalculateMood();
        }

        private void CalculateMood()
        {
            this.mood = MoodFactory.GenerateMood(this.foods.Sum(x => x.Happiness));
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{this.foods.Sum(f => f.Happiness)}")
                .Append(this.mood.MoodName);

            return builder.ToString();
        }
    }
}
