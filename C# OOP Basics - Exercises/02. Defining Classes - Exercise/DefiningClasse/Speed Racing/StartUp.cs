using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, new Car(model, fuelAmount, fuelConsumption));
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] carInfo = input.Split();
                string car = carInfo[1];
                int distane = int.Parse(carInfo[2]);

                if (cars.ContainsKey(car))
                {
                    cars[car].Move(distane);
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine(car);
            }
        }
    }
}
