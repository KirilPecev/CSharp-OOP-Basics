using FoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    class Rebel : IBuyer, IAge
    {
        private const int foodIncreaseNum = 5;

        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string Group { get; set; }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public void BuyFood()
        {
            this.Food += foodIncreaseNum;
        }
    }
}
