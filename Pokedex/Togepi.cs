using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Togepi : Pokemon
    {
        public Togepi()
        {
            this.Name = "togepi";
            this.Type1 = Poketype.fairy;
            this.Species = "Spike Ball Pokémon";
            this.Height = 0.3;
            this.Weight = 1.5;
            this.HP = 25;
            this.Attack = 15;
            this.Defense = 51;
            this.SpecialAttack = 61;
            this.SpecialDefense = 41;
            this.speed = 51;
            this.Total = 244;
            this.image = Resource1.ResourceManager.GetObject("togepi") as byte[] ?? Array.Empty<byte>();
        }
    }
}
