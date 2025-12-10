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

        public int Attack;
        public int Defense;
        public int MagicPower;
        public double CriticalChance;

        public int MaxMana;
        public int Mana;

        //Check if Alive
        public bool IsAlive()
        {
            return Health > 0;
        }
        //Attack
        public void AttackEnemy(Character target)
        {
            int damage = this.Attack - target.Defense;

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
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Magic Power: {MagicPower}");
            Console.WriteLine($"Critical Chance: {CriticalChance * 100}%");
        }
    }
}
