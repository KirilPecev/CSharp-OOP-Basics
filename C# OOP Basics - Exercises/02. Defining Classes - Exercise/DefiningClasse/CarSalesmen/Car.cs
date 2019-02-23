using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        string model;
        Engine engine;
        double? weight;
        string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;

        }

        public int Weight
        {
            set { this.weight = value; }
        }

        public string Color
        {
            set { this.color = value; }
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }

        public override string ToString()
        {
            var result = $"{this.model}:";
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.engine.ToString());
            result = string.Concat(result, this.weight == null ? "  Weight: n/a" : $"  Weight: {this.weight}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.color == null ? "  Color: n/a" : $"  Color: {this.color}");

            return result;
        }
    }
}
