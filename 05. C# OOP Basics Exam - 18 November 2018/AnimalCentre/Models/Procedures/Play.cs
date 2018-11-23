namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class Play : Procedure
    {
        private const int RemoveThatEnergy = 6;
        private const int AddThisHappiness = 12;

        public Play()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Energy -= RemoveThatEnergy;
            animal.Happiness += AddThisHappiness;

            this.AddAnimalToThisProcedure(this.GetType().Name, animal);
        }
    }
}
