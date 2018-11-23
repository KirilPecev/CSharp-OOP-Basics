namespace AnimalCentre.Models.Procedures
{
    using AnimalCentre.Models.Contracts;

    public class NailTrim : Procedure
    {
        private const int RemoveThatHappiness = 7;

        public NailTrim()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= RemoveThatHappiness;
            this.AddAnimalToThisProcedure(this.GetType().Name, animal);
        }
    }
}
