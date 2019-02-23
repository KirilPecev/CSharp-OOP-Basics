using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Dough
    {
        private string flourType;

        public string FlourType
        {
            get { return flourType; }
           private set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    flourType = value;

                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                
            }
        }

        private string bakingTechnique;

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value <= 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public Dough(string type, string technique, double weight)
        {
            this.FlourType = type;
            this.BakingTechnique = technique;
            this.Weight = weight;
        }

        public double CalculateCalories()
        {
            double typeModifier = 0;
            switch (this.FlourType.ToLower())
            {
                case "white":
                    typeModifier = 1.5;
                    break;
                case "wholegrain":
                    typeModifier = 1.0;
                    break;
            }

            double techniqueModifier = 0;
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    techniqueModifier = 0.9;
                    break;
                case "chewy":
                    techniqueModifier = 1.1;
                    break;
                case "homemade":
                    techniqueModifier = 1.0;
                    break;
            }

            return (2 * this.Weight) * typeModifier * techniqueModifier;
        }
    }
}
