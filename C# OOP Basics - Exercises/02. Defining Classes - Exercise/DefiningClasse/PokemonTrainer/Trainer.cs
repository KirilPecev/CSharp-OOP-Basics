using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            private set { pokemons = value; }
        }

        public int Badges
        {
            get { return badges; }
            private set { badges = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void AddBadge()
        {
            this.Badges++;
        }

        public void ReducePokemonsHealth()
        {
            this.Pokemons.ForEach(x => x.Health -= 10);
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                if (this.Pokemons[i].Health <= 0)
                {
                    this.Pokemons.RemoveAt(i);
                }
            }
        }
    }
}
