using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Children
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string birthday;

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Children(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}\n";
        }
    }
}
