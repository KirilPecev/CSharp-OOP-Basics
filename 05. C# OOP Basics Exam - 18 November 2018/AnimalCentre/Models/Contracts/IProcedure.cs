namespace AnimalCentre.Models.Contracts
{
    using System.Collections.Generic;

    public interface IProcedure
    {
        List<IAnimal> ProcedureHistory { get; }

        string History();

        void DoService(IAnimal animal, int procedureTime);
    }
}
