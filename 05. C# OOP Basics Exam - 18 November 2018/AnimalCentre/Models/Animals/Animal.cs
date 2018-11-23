namespace AnimalCentre.Models.Animals
{
    using AnimalCentre.Models.Contracts;
    using System;

    public abstract class Animal : IAnimal
    {
        private const string defaultOwner = "Centre";

        private int happiness;
        private int energy;

        protected Animal(string name, int energy, int happiness, int procedureTime)
        {
            this.Name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
            this.Owner = defaultOwner;
            this.IsAdopt = false;
            this.IsChipped = false;
            this.IsVaccinated = false;
        }

        public string Name { get; private set; }

        public int Happiness
        {
            get { return this.happiness; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }
                this.happiness = value;
            }
        }

        public int Energy
        {
            get { return this.energy; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }
                this.energy = value;
            }
        }

        public int ProcedureTime { get; set; }

        public string Owner { get; set; }

        public bool IsAdopt { get; set; }

        public bool IsChipped { get; set; }

        public bool IsVaccinated { get; set; }
    }
}
