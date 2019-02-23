using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    class Truck : Vehicle
    {
        private const double increasedFuelConsumption = 1.6;
        private const double keepsOnlyCoefficient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => increasedFuelConsumption;

        public override void Refuel(double amountOfFuel)
        {
            base.Refuel(amountOfFuel);
            this.FuelQuantity -= (1 - keepsOnlyCoefficient) * amountOfFuel;
        }
    }
}
