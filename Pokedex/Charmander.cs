using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Charmander : Pokemon
    {
        public Charmander()
        {
            this.Name = "chanmander";
            this.Type1 = Poketype.fire;
            this.Species = "Lizard Pokémon";
            this.Height = 0.6;
            this.Weight = 8.5;
            this.HP = 35;
            this.Attack = 50;
            this.Defense = 12;
            this.SpecialAttack = 65;
            this.SpecialDefense = 9;
            this.speed = 150;
            this.Total = 460;
            this.image = Resource1.ResourceManager.GetObject("charmander") as byte[] ?? Array.Empty<byte>();
        }
    }
}
