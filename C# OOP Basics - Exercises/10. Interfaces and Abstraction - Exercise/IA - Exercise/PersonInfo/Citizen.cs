﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name, int age, string Id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
            this.Birthdate = birthdate;
        }
    }
}
