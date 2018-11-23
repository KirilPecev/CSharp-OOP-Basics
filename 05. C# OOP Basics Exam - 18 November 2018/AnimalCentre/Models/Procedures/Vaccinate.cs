namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class Vaccinate : Procedure
    {
        private const int RemoveThatEnergy = 8;

        public Vaccinate()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Energy -= RemoveThatEnergy;
            animal.IsVaccinated = true;

            this.AddAnimalToThisProcedure(this.GetType().Name, animal);
        }
    }
}
