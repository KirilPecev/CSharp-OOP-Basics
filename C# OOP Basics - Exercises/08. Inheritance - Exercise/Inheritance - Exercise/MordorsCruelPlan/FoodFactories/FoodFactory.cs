using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan
{
    static class FoodFactory
    {
        public static Food.Food GenerateFood(string food)
        {
            switch (food.ToLower())
            {
                case "apple":
                    return new Food.Apple();
                case "cram":
                    return new Food.Cram();
                case "honeycake":
                    return new Food.HoneyCake();
                case "lembas":
                    return new Food.Lembas();
                case "melon":
                    return new Food.Melon();
                case "mushrooms":
                    return new Food.Mushrooms();
                default:
                    return new Food.Else();
            }
        }
    }
}