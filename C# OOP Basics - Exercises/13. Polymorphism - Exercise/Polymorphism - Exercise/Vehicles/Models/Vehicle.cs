using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; private set; }
        protected abstract double AdditionalConsumption { get; }
        protected double TankCapacity { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;

            this.FuelConsumption = fuelConsumption;

            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }

            this.FuelQuantity = fuelQuantity;
        }

        public void Drive(double distance)
        {
            double totalConsumption = this.FuelConsumption + AdditionalConsumption;
            double neededLitersForTravel = distance * totalConsumption;

            if (this.FuelQuantity >= neededLitersForTravel)
            {
                this.FuelQuantity -= neededLitersForTravel;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double amountOfFuel)
        {
            if (amountOfFuel <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (this.FuelQuantity + amountOfFuel <= this.TankCapacity)
            {
                this.FuelQuantity += amountOfFuel;
            }
            else
            {
                throw new ArgumentException($"Cannot fit {amountOfFuel} fuel in the tank");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
