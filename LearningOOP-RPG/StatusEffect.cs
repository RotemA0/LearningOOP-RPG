using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaudeRPG
{
    //Types
    public enum StatusEffectType
    {
        Poison,
        Burn,
        Stun,
        AttackBuff,
        DefenseBuff

    }
    public class StatusEffect
    {
        public string name;
        public StatusEffectType Type;
        public int Duration;
        public int DamagePerTurn;
        public int AttackBuff;
        public int DefenseBuff;
    }
}
