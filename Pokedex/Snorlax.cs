using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Snorlax : Pokemon
    {
        public Snorlax()
        {
            this.Name = "Snorlax";
            this.Type1 = Poketype.Normal;
            this.Species = "Sleeping Pokémon";
            this.Height = 2.1;
            this.Weight = 460;
            this.HP = 25;
            this.Attack = 47;
            this.Defense = 12;
            this.SpecialAttack = 45;
            this.SpecialDefense = 14;
            this.speed = 78;
            this.Total = 221;
            this.image = Resource1.ResourceManager.GetObject("snorlax") as byte[] ?? Array.Empty<byte>();
        }
    }
}
