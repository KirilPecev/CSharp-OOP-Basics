using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : Car
    {
        public Tesla(string model, string color, int batteries) : base(model, color, batteries) { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batterries\n");
            sb.Append($"{Start()}\n");
            sb.Append($"{Stop()}");

            return sb.ToString();
        }
    }
}
