using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Mission : IMission
    {
        private MissionStates state;
        public string CodeName { get; private set; }

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string State
        {
            get
            {
                return this.state.ToString();
            }
            private set
            {
                MissionStates state;
                if (!Enum.TryParse<MissionStates>(value, out state))
                {
                    throw new ArgumentException();
                }

                this.state = state;
            }
        }

        public void CompleteMission()
        {
            this.state = MissionStates.Finished;
        }

        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
