using System;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string model = info[0];
                int speed = int.Parse(info[1]);
                int power = int.Parse(info[2]);
                int weight = int.Parse(info[3]);
                string type = info[4];

                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < info.Length; j += 2)
                {
                    double pressure = double.Parse(info[j]);
                    int age = int.Parse(info[j + 1]);

                    tires.Add(new Tire(pressure, age));
                }

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    foreach (var item in cars)
                    {
                        if (item.Cargo.Type == "fragile")
                        {
                            foreach (var tire in item.Tires)
                            {
                                if (tire.Pressure < 1)
                                {
                                    Console.WriteLine(item.Model);
                                    break;
                                }
                            }
                        }
                    }
                    break;
                case "flamable":
                    foreach (var item in cars)
                    {
                        if (item.Cargo.Type == "flamable" && item.Engine.Power > 250)
                        {
                            Console.WriteLine(item.Model);
                        }
                    }
                    break;
            }
        }
    }
}
