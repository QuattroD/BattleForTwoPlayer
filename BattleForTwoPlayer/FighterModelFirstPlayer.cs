using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleForTwoPlayer
{
    public class FighterModelFirstPlayer
    {
        public string Name { get; set; }
        public int LVL { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Luck { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Physical_Attack { get; set; }
        public int Evasion { get; set; }
        public int Critical_Chance { get; set; }
        public int Penetration_Chance { get; set; }
        public int HealthPoint { get; set; }
        public int Magic_Attack { get; set; }
        public int Manapool { get; set; }

        public FighterModelFirstPlayer(string name, int lvl, int strength, int dexterity, int luck, int constitution, int intelligence)
        {
            Name = name;
            LVL = lvl;
            Strength = strength;
            Dexterity = dexterity;
            Luck = luck;
            Constitution = constitution;
            Intelligence = intelligence;
        }
    }
}
