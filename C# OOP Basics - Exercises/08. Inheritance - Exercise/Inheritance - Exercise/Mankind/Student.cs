using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                IsValidFacultyNumber(value);
                facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private void IsValidFacultyNumber(string number)
        {
            if (number.Length < 5 || number.Length > 10 || !number.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");

            return builder.ToString();
        }
    }
}
