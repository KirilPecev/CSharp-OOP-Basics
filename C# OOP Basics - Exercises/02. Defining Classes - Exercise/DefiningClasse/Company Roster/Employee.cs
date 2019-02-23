using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Employee
    {
        public string name;
        public double salary;
        public string postion;
        public string department;
        public string email;
        public int age;

        public Employee(string name, double salary, string postion, string department)
        {
            this.name = name;
            this.salary = salary;
            this.postion = postion;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public Employee(string name, double salary, string postion, string department, string email, int age) : this(name, salary, postion, department)
        {
            this.email = email;
            this.age = age;
        }

        public Employee(string name, double salary, string postion, string department, string email) : this(name, salary, postion, department)
        {
            this.email = email;
        }

        public Employee(string name, double salary, string postion, string department, int age) : this(name, salary, postion, department)
        {
            this.age = age;
        }
    }
}
