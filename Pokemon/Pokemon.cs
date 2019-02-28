using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        private int level = 1;
        private int hp_base;
        private int attack_base;
        private int defense_base;
        private int specialattack_base;
        private int specialdefense_base;
        private int speed;
        static int verhoogde_levels;
        static int aantal_battles;
        static int aantal_draws;
        static int aantal_generated;
        static bool levellingallowed;

        public Pokemon()
        {
            HP_Base = 10;
            Attack_base = 10;
            Defense_base = 10;
            SpecialAttack_base = 10;
            SpecialDefense_base = 10;
            Speed = 10;
        }
        public Pokemon(int health, int attack, int defense, int specialattack, int specialdefense, int speed)
        {
            HP_Base = health;
            Attack_base = attack;
            Defense_base = defense;
            SpecialAttack_base = specialattack;
            SpecialDefense_base = specialdefense;
            Speed = speed;
        }
        public int HP_Base
        {
            get { return hp_base; }
            set { hp_base = value; }
        }


        public int Attack_base
        {
            get { return attack_base; }
            set { attack_base = value; }
        }


        public int Defense_base
        {
            get { return defense_base; }
            set { defense_base = value; }
        }


        public int SpecialAttack_base
        {
            get { return specialattack_base; }
            set { specialattack_base = value; }
        }


        public int SpecialDefense_base
        {
            get { return specialdefense_base; }
            set { specialdefense_base = value; }
        }


        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Name
        {
            get; set;
        }
        public string Type
        {
            get; set;
        }
        public int Nummer { get; set; }

        public int Level
        {
            get { return level; }
            private set { level = value; }
        }
        public void VerhoogLevel()
        {
            if (Levelling_Allowed)
            {
                Level++;
            }
            else
            {
                Console.WriteLine("Levelling is niet allowed");
            }
        }
        public void VerhoogLevel(int aantal)
        {
            Level = Level + aantal;
            Verhoogde_Levels += 1;
        }
        public int Average
        {
            get
            {
                int average = 0;
                average = HP_Base + Attack_base + Defense_base + SpecialAttack_base + SpecialDefense_base + Speed;
                average = average / 6;
                return average;
            }

        }
        public int Total
        {
            get
            {
                return (HP_Base + Attack_base + Defense_base + SpecialAttack_base + SpecialDefense_base + Speed);
            }
        }
        public int HP_Full
        {
            get
            {
                return (((HP_Base + 50) * level) / 50) + 10;
            }
        }
        public int Attack_Full
        {
            get
            {
                return ((Attack_base * Level) / 50) + 5;
            }
        }
        public int Defense_Full
        {
            get
            {
                return ((Defense_base * Level) / 50) + 5;
            }
        }
        public int Speed_Full
        {
            get
            {
                return ((Speed * Level) / 50) + 5;
            }
        }
        public int SpecialDefense_Full
        {
            get
            {
                return ((SpecialDefense_base * Level) / 50) + 5;
            }
        }
        public int SpecialAttack_Full
        {
            get
            {
                return ((SpecialAttack_base * Level) / 50) + 5;
            }
        }
        public void LevelUpTester(int ingegevenlevel)
        {
            Level = ingegevenlevel;
            Console.WriteLine(Name + " Stats: " + HP_Full + ", " + Attack_Full + ", " + Defense_Full + ", " + SpecialAttack_Full + ", " + SpecialDefense_Full + ", " + Speed_Full);
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name + "  (level " + Level + ")");
            Console.WriteLine("Base Stats:");
            Console.WriteLine("     *Health = " + HP_Base);
            Console.WriteLine("     *Speed = " + Speed);
            Console.WriteLine("     *Attack = " + Attack_base);
            Console.WriteLine("     *Defense = " + Defense_base);
            Console.WriteLine("     *Special Attack = " + SpecialAttack_base);
            Console.WriteLine("     *Special Defense = " + SpecialDefense_base);
            Console.WriteLine("Full stats: ");
            Console.WriteLine("     *Health = " + HP_Full);
            Console.WriteLine("     *Speed = " + Speed_Full);
            Console.WriteLine("     *Attack = " + Attack_Full);
            Console.WriteLine("     *Defense = " + Defense_Full);
            Console.WriteLine("     *Special Attack = " + SpecialAttack_Full);
            Console.WriteLine("     *Special Defense = " + SpecialDefense_Full);
        }
        static Pokemon GeneratePokemon()
        {
            Pokemon poke = new Pokemon();
            Console.WriteLine("Geef de naam van je favoriete pokemon in: ");
            poke.Name = Console.ReadLine();
            Console.WriteLine("Geef nu het type van deze pokemon in: ");
            poke.Type = Console.ReadLine();
            Console.WriteLine("Geef nu de nummer van de pokemon in: ");
            poke.Nummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base HP in: ");
            poke.HP_Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Attack in: ");
            poke.Attack_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Defense in: ");
            poke.Defense_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Special Attack in: ");
            poke.SpecialAttack_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nu de base Special Defense in: ");
            poke.SpecialDefense_base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("En als laatste nog de base Speed: ");
            poke.Speed = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Tot welk lvl moet de pokemon geleveled worden?");
            int lvl = Convert.ToInt32(Console.ReadLine());
            poke.LevelUpTester(lvl);
            System.Threading.Thread.Sleep(500);
            poke.ShowInfo();
            return poke;
        }
        static Pokemon GeneratorPokemon()
        {
            Random R = new Random();
            Pokemon poke = new Pokemon();
            poke.HP_Base = R.Next(1, 20);
            poke.Attack_base = R.Next(20, 100);
            poke.Defense_base = R.Next(20, 100);
            poke.SpecialAttack_base = R.Next(20, 150);
            poke.SpecialDefense_base = R.Next(20, 150);
            poke.Speed = R.Next(10, 100);
            Aantal_Generated += 1;
            return poke;
        }
        static int Battle(Pokemon poke1, Pokemon poke2)
        {
            Aantal_Battles += 1;
            if (poke1 == null || poke2 == null)
            {
                Console.WriteLine("Een of beide van de pokemon bestaat niet. Het programma zal nu afsluiten...");
                System.Threading.Thread.Sleep(500);
                Environment.Exit(0);
            }
            int Full_Poke1 = poke1.Total;
            int Full_Poke2 = poke2.Total;
            if (Full_Poke1 < Full_Poke2)
            {
                Console.WriteLine(poke2.Name + " wint de battle!");
                poke2.VerhoogLevel();
                return 1;
            }
            if (Full_Poke1 > Full_Poke2)
            {
                Console.WriteLine(poke1.Name + " wint de battle!");
                poke1.VerhoogLevel();
                return 1;
            }
            if (Full_Poke1 == Full_Poke2)
            {
                Console.WriteLine("Niemand wint (gelijkspel)");
                Aantal_Draws += 1;
                return 0;
            }
            else
            {
                return 0;
            }
            
        }
        

        static int Verhoogde_Levels
        {
            get { return verhoogde_levels; }
            set { verhoogde_levels = value; }
        }
        static int Aantal_Battles
        {
            get
            {
                return aantal_battles;
            }
            set
            {
                aantal_battles = value;
            }
        }
        static int Aantal_Draws
        {
            get
            {
                return aantal_draws;
            }
            set
            {
                aantal_draws = value;
            }
        }
        static int Aantal_Generated
        {
            get
            {
                return aantal_generated;
            }
            set
            {
                aantal_generated = value;
            }
        }
        static void Info()
        {
            Console.WriteLine("Samenvatting van de spelen:");
            Console.WriteLine("Aantal verhoogde levels: " + Verhoogde_Levels);
            Console.WriteLine("Aantal battles: "+ Aantal_Battles);
            Console.WriteLine("Aantal Draws: "+ Aantal_Draws);
            Console.WriteLine("Aantal gegenereerde pokemon: " + Aantal_Generated);
        }
        static bool Levelling_Allowed
        {
            get
            {
                return levellingallowed;
            }
            set
            {
                levellingallowed = value;
            }
        }
    }
}
