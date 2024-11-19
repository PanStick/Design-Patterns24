using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce_Projektowe.Template_Method
{
    abstract class Pokemon
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Pokemon(string name, int power, int attack, int defense)
        {
            Name = name;
            Power = power;
            Attack = attack;
            Defense = defense;
        }

        public abstract double CalcImpact();

        public int CalcDamage()
        {
            double val = CalcImpact();
            return (int)(Power * val);
        }
    }

    class FightingPokemon : Pokemon
    {
        public FightingPokemon(string name, int power, int attack, int defense) : base(name, power, attack, defense) { }
        override public double CalcImpact()
        {
            return Attack * 1.5;
        }
    }

    class PoisonPokemon : Pokemon
    {
        public PoisonPokemon(string name, int power, int attack, int defense) : base(name, power, attack, defense) { }
        override public double CalcImpact()
        {
            return Attack + Defense * 0.5;
        }
    }

    class GroundPokemon : Pokemon
    {
        public GroundPokemon(string name, int power, int attack, int defense) : base(name, power, attack, defense) { }
        override public double CalcImpact()
        {
            return Attack * 0.75 + Defense * 0.75;
        }

    }
}
