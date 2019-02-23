using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Pokemon
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Type}\n";
        }
    }
}
