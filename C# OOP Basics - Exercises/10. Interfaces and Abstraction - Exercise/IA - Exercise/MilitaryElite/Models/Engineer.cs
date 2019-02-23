using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<Repair> repairs;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) :
            base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<Repair>();
        }

        public IReadOnlyCollection<IRepair> Repairs { get; }

        public void AddRepair(Repair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Repairs:");

            foreach (var repair in this.repairs)
            {
                builder.AppendLine(repair.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
