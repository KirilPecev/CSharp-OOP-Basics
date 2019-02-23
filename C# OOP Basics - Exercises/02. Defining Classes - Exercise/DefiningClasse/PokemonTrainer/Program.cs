using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Trainer> pokemons = new Dictionary<string, Trainer>();
            while (input != "Tournament")
            {
                string[] info = input.Split();
                string trainer = info[0];
                string pokemonName = info[1];
                string element = info[2];
                int health = int.Parse(info[3]);

                if (!pokemons.ContainsKey(trainer))
                {
                    pokemons.Add(trainer, new Trainer(trainer));
                    pokemons[trainer].AddPokemon(new Pokemon(pokemonName, element, health));
                }
                else
                {
                    pokemons[trainer].AddPokemon(new Pokemon(pokemonName, element, health));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                foreach (var trainer in pokemons.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        trainer.ReducePokemonsHealth();                       
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var t in pokemons.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{t.Key} {t.Value.Badges} {t.Value.Pokemons.Count}");
            }
        }
    }
}
