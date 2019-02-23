using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    class Human
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            protected set
            {
                IsValidFirstName(value);
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            protected set
            {
                IsValidLastName(value);
                lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private void IsValidFirstName(string name)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: firstName");
            }
            else if (name.Length <= 3)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
            }
        }

        private void IsValidLastName(string name)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: lastName");
            }
            else if (name.Length <= 2)
            {
                throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}");

            return builder.ToString();
        }
    }
}
