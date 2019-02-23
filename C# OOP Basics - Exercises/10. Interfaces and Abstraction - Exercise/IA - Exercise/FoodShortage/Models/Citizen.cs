using FoodShortage.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    class Citizen : IAge, IIdentifiable, IBirthable, IBuyer
    {
        private const int foodIncreaseNum = 10;

        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public void BuyFood()
        {
            this.Food += foodIncreaseNum;
        }
    }
}
