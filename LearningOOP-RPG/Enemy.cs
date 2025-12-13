using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    public class Enemy : Character
    {


        static Random random = new Random();
        public int ExperienceReward = 25;
        public int GoldDrop = 15;
        public string Special;
        public string Description = "A small, green creature with a rusty dagger";
        public StatusEffect InflictEffect; 
        public int EffectChance;

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Experience Reward: {ExperienceReward}");
            Console.WriteLine($"Gold Drop: {GoldDrop}");
        }
        public override void AttackEnemy(Character target)
        {
            base.AttackEnemy(target);

            if (this.InflictEffect != null)
            {
                StatusEffect copiedEffect = new StatusEffect
                {
                    Name = this.InflictEffect.Name,
                    Type = this.InflictEffect.Type,
                    Duration = this.InflictEffect.Duration,
                    DamagePerTurn = this.InflictEffect.DamagePerTurn,
                    AttackBuff = this.InflictEffect.AttackBuff,
                    DefenseBuff = this.InflictEffect.DefenseBuff
                };
                int num = random.Next(1, 100 + 1);
                if (num <= EffectChance)
                {
                    target.ActiveEffects.Add(copiedEffect);
                }
            }
        }
    }
}
