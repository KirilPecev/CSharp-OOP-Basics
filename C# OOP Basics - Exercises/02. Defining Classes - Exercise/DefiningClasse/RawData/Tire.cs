using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        double pressure;
        int age;

        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public double Pressure
        {
            get { return pressure; }
            private set { pressure = value; }
        }
    }
}
