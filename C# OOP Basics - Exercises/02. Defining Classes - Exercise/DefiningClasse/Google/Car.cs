using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string speed;

        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Car(string model, string speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }
    }
}
