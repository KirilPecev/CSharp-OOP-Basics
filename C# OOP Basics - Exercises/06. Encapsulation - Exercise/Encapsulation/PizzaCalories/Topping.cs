using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Topping
    {
        private string type;

        public string Type
        {
            get { return type; }
            private set
            {
                if (value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            double modifier = 0;
            switch (this.Type.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                case "sauce":
                    modifier = 0.9;
                    break;
            }

            return this.Weight * modifier * 2;
        }
    }
}
