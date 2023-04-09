using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonDays.Entities
{
    internal class Mascote
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public List<Abilities> abilities { get; set; } = new List<Abilities>();
        public Mascote()
        {

        }

        public Mascote(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }
    }
}
