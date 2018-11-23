namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;
    using System;

    public class Chip : Procedure
    {
        private const int RemoveThatHappiness = 5;

        public Chip()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }

            base.DoService(animal, procedureTime);

            animal.Happiness -= RemoveThatHappiness;
            animal.IsChipped = true;

            this.AddAnimalToThisProcedure(this.GetType().Name, animal);
        }
    }
}
