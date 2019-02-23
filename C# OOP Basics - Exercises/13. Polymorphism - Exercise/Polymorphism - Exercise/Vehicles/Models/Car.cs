using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    class Car : Vehicle
    {
        private const double increasedFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => increasedFuelConsumption;

    }
}
