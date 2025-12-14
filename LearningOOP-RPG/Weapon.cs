using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    public class Weapon : Item
    {
        public int RequiredLevel;
        public string Special;
        public int Damage;
        public double CritChanceBonus;
        public StatusEffect StatusEffect;
    }
}
