using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon Squirtle = new Pokemon();
            Squirtle.Attack_base = 48;
            Squirtle.Defense_base = 65;
            Squirtle.HP_Base = 44;
            Squirtle.SpecialAttack_base = 50;
            Squirtle.SpecialDefense_base = 64;
            Squirtle.Speed = 43;
            Console.WriteLine("Squirtle:");
            Console.WriteLine("Full HP: " + Squirtle.HP_Full + " Total: " + Squirtle.Total + " Average: " + Squirtle.Average);
            Pokemon Mewtwo = new Pokemon();
            Mewtwo.Attack_base = 48;
            Mewtwo.Defense_base = 65;
            Mewtwo.HP_Base = 44;
            Mewtwo.SpecialAttack_base = 50;
            Mewtwo.SpecialDefense_base = 64;
            Mewtwo.Speed = 43;
            Console.WriteLine("Mewtwo:");
            Console.WriteLine("Full HP: " + Mewtwo.HP_Full + " Total: " + Mewtwo.Total + " Average: " + Mewtwo.Average);

        }
    }
}
