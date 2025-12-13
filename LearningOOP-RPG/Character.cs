using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    public class Character
    {
        public string Name;

        public int Level;

        public int MaxHealth;
        public int Health;

        public int CurrentAttack;
        public int BaseAttack;
        public int CurrentDefense;
        public int BaseDefense;
        public int MagicPower;
        public double CriticalChance;

        public int MaxMana;
        public int Mana;

        public List<StatusEffect> ActiveEffects = new List<StatusEffect>();

        //Check if Alive
        public bool IsAlive()
        {
            return Health > 0;
        }
        //Attack
        public virtual void AttackEnemy(Character target)
        {
            int damage = this.CurrentAttack;
            if (this is Player player)
            {
                // Now we can access Player-specific stuff!
                if (player.EquippedWeapon != null)
                {
                    damage += player.EquippedWeapon.Damage;
                }
            }
            damage = damage - target.CurrentDefense;
            if (damage < 1)
            {
                damage = 1;
            }
            Console.WriteLine($"{this.Name} attacked {target.Name} for {damage} damage!");
            target.TakeDamage(damage);
        }
        //Take damage
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }

            Console.WriteLine($"Damage taken: {damage}");
            Console.WriteLine($"Health: {Health}");
        }
        //Display stats
        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Health: {Health}/{MaxHealth}");
            Console.WriteLine($"Mana: {Mana}/{MaxMana}");
            Console.WriteLine($"Attack: {BaseAttack}");
            Console.WriteLine($"Defense: {BaseDefense}");
            Console.WriteLine($"Magic Power: {MagicPower}");
            Console.WriteLine($"Critical Chance: {CriticalChance * 100}%");
        }

        //Apply Effect
        public bool ApplyStatusEffects() //Rember to look over!!! Super important
        {
            bool isStunned = false;
            CurrentAttack = BaseAttack;
            CurrentDefense = BaseDefense;

            foreach (StatusEffect effect in ActiveEffects)
            {
                
                if (effect.Type == StatusEffectType.Burn || effect.Type == StatusEffectType.Poison)
                {
                    Health -= effect.DamagePerTurn;
                }
                else if (effect.Type == StatusEffectType.Stun)
                {
                    isStunned = true;
                }
                else if (effect.Type == StatusEffectType.AttackBuff)
                {
                    CurrentAttack += effect.AttackBuff;
                    
                }
                else
                {
                    CurrentDefense += effect.DefenseBuff;
                    
                }
                    effect.Duration--;
                
            }
            ActiveEffects.RemoveAll(e => e.Duration <= 0);
            return isStunned;
        }
    }
}
