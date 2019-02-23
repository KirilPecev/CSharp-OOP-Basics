using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles.Models;

namespace Vehicles.Core
{
    class Engine
    {
        public void Run()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string[] carInfo = Console.ReadLine().Split();
            vehicles.Add(new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3])));

            string[] truckInfo = Console.ReadLine().Split();
            vehicles.Add(new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3])));

            string[] busInfo = Console.ReadLine().Split();
            vehicles.Add(new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3])));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string type = input[1];
                double value = double.Parse(input[2]);

                try
                {
                    switch (command)
                    {
                        case "Drive":
                            Drive(type, value, vehicles);
                            break;
                        case "Refuel":
                            Refuel(type, value, vehicles);
                            break;
                        case "DriveEmpty":
                            DriveEmpty(type, value, vehicles);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        private void DriveEmpty(string type, double value, List<Vehicle> vehicles)
        {
            var vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == type);
            ((Bus)vehicle).SwitchOffAirConditioner();
            vehicle.Drive(value);
            ((Bus)vehicle).SwitchOnAirConditioner();
        }

        private void Refuel(string type, double value, List<Vehicle> vehicles)
        {
            var vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == type);
            vehicle.Refuel(value);
        }

        private void Drive(string type, double value, List<Vehicle> vehicles)
        {
            var vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == type);
            vehicle.Drive(value);
        }
    }
}
