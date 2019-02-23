using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Spy : Soldier, ISpy
    {
        public Spy(string firstName, string lastName, string id, int codeNumber) :
            base(firstName, lastName, id)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
