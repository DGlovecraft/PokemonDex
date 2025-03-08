using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            this.Name = "Mewtwo";
            this.Type1 = Poketype.Psychic;
            this.Species = "Genetic";
            this.Height = 2;
            this.Weight = 122;
            this.HP = 150;
            this.Attack = 400;
            this.Defense = 402;
            this.SpecialAttack = 600;
            this.SpecialDefense = 1450;
            this.speed = 555;
            this.Total = 3557;
            this.image = Resource1.ResourceManager.GetObject("mewtwo") as byte[] ?? Array.Empty<byte>();
        }
    }
}
