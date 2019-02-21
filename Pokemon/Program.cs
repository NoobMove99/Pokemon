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
            Squirtle.Name = "Squirtle";
            Squirtle.Type = "Water";
            Squirtle.Nummer = 7;
            Squirtle.Attack_base = 48;
            Squirtle.Defense_base = 65;
            Squirtle.HP_Base = 44;
            Squirtle.SpecialAttack_base = 50;
            Squirtle.SpecialDefense_base = 64;
            Squirtle.Speed = 43;
            Console.WriteLine("Squirtle:");
            Console.WriteLine("Full HP: " + Squirtle.HP_Full + " Total: " + Squirtle.Total + " Average: " + Squirtle.Average);
            Pokemon Mewtwo = new Pokemon();
            Mewtwo.Name = "Mewtwo";
            Mewtwo.Type = "Physic";
            Mewtwo.Nummer = 150;
            Mewtwo.Attack_base = 110;
            Mewtwo.Defense_base = 90;
            Mewtwo.HP_Base = 106;
            Mewtwo.SpecialAttack_base = 154;
            Mewtwo.SpecialDefense_base = 690;
            Mewtwo.Speed = 130;
            Console.WriteLine("Mewtwo:");
            Console.WriteLine("Full HP: " + Mewtwo.HP_Full + " Total: " + Mewtwo.Total + " Average: " + Mewtwo.Average);
            Console.WriteLine("LevelUpTester: ");
            for (int i = 0; i < 20; i++)
            {
                Squirtle.LevelUpTester(i);
                Mewtwo.LevelUpTester(i);
            }
            Console.ReadLine();

        }
    }
}
