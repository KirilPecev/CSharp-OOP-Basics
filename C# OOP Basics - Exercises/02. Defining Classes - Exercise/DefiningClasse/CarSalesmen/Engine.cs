using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        string model;
        int power;
        int? displacement;
        string efficiency;

        public string Model
        {
            get { return this.model; }
        }

        public int? Displaacement
        {
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            set { this.efficiency = value; }
        }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public override string ToString()
        {
            var result = $"  {this.model}:";
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, $"    Power: {this.power}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.displacement == null ? "    Displacement: n/a" : $"    Displacement: {this.displacement}");
            result = string.Concat(result, Environment.NewLine);
            result = string.Concat(result, this.efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {this.efficiency}");
            result = string.Concat(result, Environment.NewLine);

            return result;
        }
    }
}
