using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Car : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int batteries;

        public string Model { get => this.model; set => model = value; }
        public string Color { get => this.color; set => color = value; }
        public int Battery { get => this.batteries; set => batteries = value; }

        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public Car(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = batteries;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Color} {this.GetType().Name} {this.Model}\n");
            sb.Append($"{Start()}\n");
            sb.Append($"{Stop()}");

            return sb.ToString();
        }
    }
}
