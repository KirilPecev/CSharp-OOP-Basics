namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class Fitness : Procedure
    {
        private const int RemoveThatHappiness = 3;
        private const int AddThisEnergy = 10;

        public Fitness()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= RemoveThatHappiness;
            animal.Energy += AddThisEnergy;
            this.AddAnimalToThisProcedure(this.GetType().Name, animal);
        }
    }
}
