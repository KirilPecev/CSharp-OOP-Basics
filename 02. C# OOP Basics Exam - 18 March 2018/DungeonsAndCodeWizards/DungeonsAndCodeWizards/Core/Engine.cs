using System;
using System.Linq;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        private DungeonMaster master;

        public Engine()
        {
            this.master = new DungeonMaster();
        }

        public void Run()
        {
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split();
                try
                {
                    Play(tokens);
                    if (this.master.IsGameOver())
                    {                       
                        break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Parameter Error: " + ex.Message);
                }
                catch (InvalidOperationException ix)
                {
                    Console.WriteLine("Invalid Operation: " + ix.Message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Final stats:");
            Console.WriteLine(this.master.GetStats());
        }

        private void Play(string[] tokens)
        {
            string command = tokens[0];

            switch (command)
            {
                case "JoinParty":
                    Console.WriteLine(this.master.JoinParty(tokens.Skip(1).ToArray()));
                    break;
                case "AddItemToPool":
                    Console.WriteLine(this.master.AddItemToPool(tokens.Skip(1).ToArray()));
                    break;
                case "PickUpItem":
                    Console.WriteLine(this.master.PickUpItem(tokens.Skip(1).ToArray()));
                    break;
                case "UseItem":
                    Console.WriteLine(this.master.UseItem(tokens.Skip(1).ToArray()));
                    break;
                case "UseItemOn":
                    Console.WriteLine(this.master.UseItemOn(tokens.Skip(1).ToArray()));
                    break;
                case "GiveCharacterItem":
                    Console.WriteLine(this.master.GiveCharacterItem(tokens.Skip(1).ToArray()));
                    break;
                case "GetStats":
                    Console.WriteLine(this.master.GetStats());
                    break;
                case "Attack":
                    Console.WriteLine(this.master.Attack(tokens.Skip(1).ToArray()));
                    break;
                case "Heal":
                    Console.WriteLine(this.master.Heal(tokens.Skip(1).ToArray()));
                    break;
                case "EndTurn":
                    Console.WriteLine(this.master.EndTurn(tokens.Skip(1).ToArray()));
                    break;
            }
        }
    }
}
