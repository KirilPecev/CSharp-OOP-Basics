using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }

        public IReadOnlyCollection<IPrivate> Privates
        {
            get
            {
                return this.privates;
            }
        }

        public void AddPrivate(Private newPrivate)
        {
            this.privates.Add(newPrivate);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var current in this.privates)
            {
                builder.AppendLine("  " + current.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
