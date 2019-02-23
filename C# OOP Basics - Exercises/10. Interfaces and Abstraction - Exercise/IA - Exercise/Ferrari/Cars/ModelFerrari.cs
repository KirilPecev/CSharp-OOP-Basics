using Ferrari.Interfaces;

namespace Ferrari.Cars
{
    class ModelFerrari : ICarable
    {
        public string Model { get; set; }
        public string Driver { get; set; }

        public ModelFerrari(string model, string driver)
        {
            this.Model = model;
            this.Driver = driver;
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string gasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{Brakes()}/{gasPedal()}/{this.Driver}";
        }
    }
}
