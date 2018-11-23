namespace AnimalCentre.Models.Factories
{
    using AnimalCentre.Models.Procedures;
    using System;

    public static class ProcedureFactory
    {
        public static Procedure CreateProcedure(string type)
        {
            switch (type)
            {
                case "Chip":
                    return new Chip();
                case "DentalCare":
                    return new DentalCare();
                case "Fitness":
                    return new Fitness();
                case "NailTrim":
                    return new NailTrim();
                case "Play":
                    return new Play();
                case "Vaccinate":
                    return new Vaccinate();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
