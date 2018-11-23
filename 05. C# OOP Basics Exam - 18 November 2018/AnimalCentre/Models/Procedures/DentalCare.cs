namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class DentalCare : Procedure
    {
        private const int AddThisHappiness = 12;
        private const int AddThisEnergy = 10;

        public DentalCare()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness += AddThisHappiness;
            animal.Energy += AddThisEnergy;


            this.AddAnimalToThisProcedure(this.GetType().Name, animal);
        }
    }
}
