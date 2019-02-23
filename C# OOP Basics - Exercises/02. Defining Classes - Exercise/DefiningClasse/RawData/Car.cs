using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public List<Tire> Tires
        {
            get { return tires; }
            private set { tires = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
            private set { cargo = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            private set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

    }
}
