using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public enum Poketype
    {
        None,
        God,
        Electric,
        Hydro,
        Pyro,
        Cyro,
        Wind,
        Psychic,
        Normal,
        Fly,
        fire,
        fairy,
    }
    public class Pokemon
    {
        public string Name;
        public int HP;
        public int Attack;
        public int Defense;
        public int SpecialAttack;
        public int SpecialDefense;
        public int speed;
        public int Total;
        public double Height;
        public double Weight;
        public string Species;
        public Poketype Type1;
        public Poketype Type2;
        public byte[] image;
        public Pokemon()
        {

        }
        public void setName(string name)
        {
            Name = name;
        }
        public byte[] getImage()
        {
            return image;
        }
    }
}
    