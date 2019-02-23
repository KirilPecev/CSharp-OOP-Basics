using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    class Worker : Human
    {
        private decimal weekSalary;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                IsValidWeekSalary(value);
                weekSalary = value;
            }
        }

        private decimal workingHours;

        public decimal WorkingHours
        {
            get { return workingHours; }
            set
            {
                IsValidWorkingHours(value);
                workingHours = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        private decimal GetSalaryPerHour()
        {
            return this.WeekSalary / (this.WorkingHours * 5);
        }


        private void IsValidWeekSalary(decimal salary)
        {
            if (salary <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
        }

        private void IsValidWorkingHours(decimal workingHours)
        {
            if (workingHours < 1 || workingHours > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:F2}")
                .AppendLine($"Hours per day: {this.WorkingHours:F2}")
                .Append($"Salary per hour: {GetSalaryPerHour():F2}");

            return builder.ToString();
        }
    }
}
