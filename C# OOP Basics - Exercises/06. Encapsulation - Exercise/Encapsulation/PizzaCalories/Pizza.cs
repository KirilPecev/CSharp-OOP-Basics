using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 0 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        private Dough dough;

        private List<Topping> toppings;

        private int toppingsCount;

        public int ToppingsCount
        {
            get { return toppingsCount; }
            private set
            {
                if (value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppingsCount = value;
            }
        }

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        public void AddDough(Dough dough)
        {
            this.dough = dough;
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
            this.ToppingsCount++;
        }

        public double Calories()
        {
            double calories = 0;
            foreach (var topping in toppings)
            {
                calories += topping.CalculateCalories();
            }

            return this.dough.CalculateCalories() + calories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {Calories():f2} Calories.";
        }
    }
}
