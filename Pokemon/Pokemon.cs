using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {
        private int level;
        private int hp_base;
        private int attack_base;
        private int defense_base;
        private int specialattack_base;
        private int specialdefense_base;
        private int speed;

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
    }
}
