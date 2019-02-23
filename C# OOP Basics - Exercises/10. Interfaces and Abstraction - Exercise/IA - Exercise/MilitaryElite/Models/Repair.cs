using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Repair : IRepair
    {
        public Repair(string partName, int hours)
        {
            this.PartName = partName;
            this.HoursWorked = hours;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            return $"  Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
