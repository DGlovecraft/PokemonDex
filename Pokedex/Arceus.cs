using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Arceus : Pokemon
    {
        public Arceus()
        {
            this.Name = "Arceus";
            this.Type1 = Poketype.God;
            this.Type2 = Poketype.Fly;
            this.Species = "God Pokémon";
            this.Height = 3.2;
            this.Weight = 350;
            this.HP = 1;
            this.Attack = 1;
            this.Defense = 1;
            this.SpecialAttack = 1;
            this.SpecialDefense = 1;
            this.speed = 1;
            this.Total = 1;
            this.image = Resource1.ResourceManager.GetObject("arceus") as byte[] ?? Array.Empty<byte>();
        }
    }
}
