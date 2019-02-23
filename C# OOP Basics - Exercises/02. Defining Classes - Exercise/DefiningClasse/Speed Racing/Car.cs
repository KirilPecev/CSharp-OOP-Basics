using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumption;
        int traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.traveledDistance = 0;
        }

        public void Move(int distance)
        {
            double carCanMove = this.fuelAmount / this.fuelConsumption;
            if (carCanMove >= distance)
            {
                this.fuelAmount -= distance * this.fuelConsumption;
                this.traveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:f2} {this.traveledDistance}";
        }
    }
}
