using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public string Name { get; private set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons
        {
            get
            {
                this.pokemons.RemoveAll(p => p.Health <= 0);
                return this.pokemons;
            }
        }
    }
}
