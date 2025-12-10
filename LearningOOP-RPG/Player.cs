using ClaudeRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    public class Player : Character
    {
        public int Experience = 0;
        public int ExperienceToNextLevel = 100;

        public int Gold = 50;

        public Weapon EquippedWeapon;
        public Armor EquippedArmor;
        public Inventory Inventory = new Inventory();


        //Heal
        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }

            Console.WriteLine($"Healed: {amount}");
            Console.WriteLine($"Health: {Health}");
        }
        //Display Stats
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Experience: {Experience}/{ExperienceToNextLevel}");
            Console.WriteLine($"Gold: {Gold}");
        }
        //Equip Weapon
        public void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
            Console.WriteLine($"{weapon.Name} Equiped!");
        }
        //Equip Armor
        public void EquipArmor(Armor armor)
        {
            EquippedArmor = armor;
            Console.WriteLine($"{armor.Name} Equiped!");
        }
    }
}
