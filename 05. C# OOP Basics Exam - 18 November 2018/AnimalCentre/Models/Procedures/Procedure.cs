namespace AnimalCentre.Models.Procedures
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Procedure : IProcedure
    {
        private List<IAnimal> procedureHistory;

        protected Procedure()
        {
            procedureHistory = new List<IAnimal>();
        }

        public List<IAnimal> ProcedureHistory
        {
            get
            {
                return this.procedureHistory;
            }
            private set
            {
                this.procedureHistory = value;
            }
        }

        public string History()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            foreach (var animal in this.ProcedureHistory)
            {
                sb.AppendLine(animal.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            CheckProcedureTime(animal, procedureTime);
        }

        private void CheckProcedureTime(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime < procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.ProcedureTime -= procedureTime;
        }

        protected void AddAnimalToThisProcedure(string type, IAnimal animal)
        {
            this.ProcedureHistory.Add(animal);
        }
    }
}
