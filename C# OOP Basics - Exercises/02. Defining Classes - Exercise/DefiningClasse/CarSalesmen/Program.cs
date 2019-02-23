using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                AddEngine(engines, engineInfo);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                AddCar(cars, carInfo, engines);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        private static void AddCar(List<Car> cars, string[] carInfo, List<Engine> engines)
        {
            Engine current = engines.Where(x => x.Model == carInfo[1]).FirstOrDefault();
            if (carInfo.Length == 4)
            {
                cars.Add(new Car(carInfo[0], current, int.Parse(carInfo[2]), carInfo[3]));
            }
            else if (carInfo.Length == 3)
            {
                if (IsInt(carInfo[2]))
                {
                    cars.Add(new Car(carInfo[0], current, int.Parse(carInfo[2])));
                }
                else
                {
                    cars.Add(new Car(carInfo[0], current, carInfo[2]));
                }
            }
            else
            {
                cars.Add(new Car(carInfo[0], current));
            }

        }

        private static void AddEngine(List<Engine> engines, string[] engineInfo)
        {
            if (engineInfo.Length == 4)
            {
                engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]));
            }
            else if (engineInfo.Length == 2)
            {
                engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1])));
            }
            else
            {
                if (IsInt(engineInfo[2]))
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2])));
                }
                else
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]));
                }
            }
        }

        private static bool IsInt(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
