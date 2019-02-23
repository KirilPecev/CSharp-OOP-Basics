using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public Citizen(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
