using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Enums;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double increasedFuelConsumption = 1.4;
        private const double increasedFuelConsumptionEmptyBus = 0;

        private AirConditioner airConditioner;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => airConditioner == AirConditioner.On ?
            increasedFuelConsumption : increasedFuelConsumptionEmptyBus;

        public void SwitchOnAirConditioner()
        {
            this.airConditioner = AirConditioner.On;
        }

        public void SwitchOffAirConditioner()
        {
            this.airConditioner = AirConditioner.Off;
        }
    }
}
