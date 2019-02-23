using ExplicitInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Models
{
    class Citizen : IResident, IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }

        public string GetName()
        {
            return this.Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
