using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        private Company company;

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        private List<Parents> parents;

        public List<Parents> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        private List<Children> children;

        public List<Children> Children
        {
            get { return children; }
            set { children = value; }
        }

        private Car car;

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public Person()
        {
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parents>();
            this.Children = new List<Children>();
        }

        public Person(Company company) : this()
        {
            this.Company = company;
        }

        public Person(List<Parents> parents)
        {
            this.Parents = parents;
        }

        public Person(List<Children> children)
        {
            this.Children = children;
        }

        public Person(Car car) : this()
        {
            this.Car = car;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Company:\n");
            if (this.Company != null)
            {
                sb.Append(this.Company.ToString());
               // sb.Append(Environment.NewLine);
            }

            sb.Append("Car:\n");
            if (this.Car != null)
            {
                sb.Append(this.Car.ToString());
               // sb.Append(Environment.NewLine);
            }

            sb.Append("Pokemon:\n");
            if (this.Pokemons != null)
            {
                this.Pokemons.ForEach(x => sb.Append(x.ToString()));
            }

            sb.Append("Parents:\n");
            if (this.Parents != null)
            {
                this.Parents.ForEach(x => sb.Append(x.ToString()));
            }

            sb.Append("Children:\n");
            if (this.Children != null)
            {
                this.Children.ForEach(x => sb.Append(x.ToString()));
            }

            return sb.ToString();
        }
    }
}
