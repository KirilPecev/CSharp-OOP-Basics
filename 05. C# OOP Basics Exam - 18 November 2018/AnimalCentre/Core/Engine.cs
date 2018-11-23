namespace AnimalCentre.Core
{
    using System;

    public class Engine
    {
        private AnimalCentre centre;

        public Engine()
        {
            this.centre = new AnimalCentre();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();

                try
                {
                    Play(tokens);
                }
                catch (InvalidOperationException x)
                {
                    Console.WriteLine("InvalidOperationException: " + x.Message);
                }
                catch (ArgumentException x)
                {
                    Console.WriteLine("ArgumentException: " + x.Message);
                }

                input = Console.ReadLine();
            }

            string output = this.centre.End();
            if (output != "")
            {
                Console.WriteLine(output);
            }

        }

        private void Play(string[] tokens)
        {

            string output = "";
            string command = tokens[0];

            switch (command)
            {
                case "RegisterAnimal":
                    output = this.centre.RegisterAnimal(tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]));
                    break;
                case "Chip":
                    output = this.centre.Chip(tokens[1], int.Parse(tokens[2]));
                    break;
                case "Vaccinate":
                    output = this.centre.Vaccinate(tokens[1], int.Parse(tokens[2]));
                    break;
                case "Fitness":
                    output = this.centre.Fitness(tokens[1], int.Parse(tokens[2]));
                    break;
                case "Play":
                    output = this.centre.Play(tokens[1], int.Parse(tokens[2]));
                    break;
                case "DentalCare":
                    output = this.centre.DentalCare(tokens[1], int.Parse(tokens[2]));
                    break;
                case "NailTrim":
                    output = this.centre.NailTrim(tokens[1], int.Parse(tokens[2]));
                    break;
                case "Adopt":
                    output = this.centre.Adopt(tokens[1], tokens[2]);
                    break;
                case "History":
                    output = this.centre.History(tokens[1]);
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
