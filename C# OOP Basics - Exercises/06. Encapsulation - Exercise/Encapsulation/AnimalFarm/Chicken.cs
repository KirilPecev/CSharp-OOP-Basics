﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    class Chicken
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                age = value;
            }
        }

        private double productPerDay;

        public double ProductPerDay
        {
            get { return productPerDay; }
            private set { productPerDay = value; }
        }

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.ProductPerDay = CalculateProductPerDay();
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }

        public override string ToString()
        {
            return $"Chicken {this.name} (age {this.age}) can produce {this.productPerDay} eggs per day.";
        }
    }
}
