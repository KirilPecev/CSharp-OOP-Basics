using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    abstract class Soldier : ISoldier
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Id { get; private set; }

        public Soldier(string id, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}
