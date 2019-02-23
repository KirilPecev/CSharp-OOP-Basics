using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        private string name;

        protected string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        private int age;

        protected int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        private string gender;

        protected string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.GetType().Name);
            sb.Append(Environment.NewLine);
            sb.Append($"{this.Name} {this.Age} {this.Gender}");
            sb.Append(Environment.NewLine);
            sb.Append($"{ProduceSound()}");
            return sb.ToString();
        }
    }
}
