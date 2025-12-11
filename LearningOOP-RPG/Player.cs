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
            if (EquippedWeapon != null)
            {
                Attack -= EquippedWeapon.Damage; 
            }
            EquippedWeapon = weapon;
            Attack += weapon.Damage;  
            Console.WriteLine($"{weapon.Name} Equipped!");
        }
        //Equip Armor
        public void EquipArmor(Armor armor)
        {
            if (EquippedArmor != null)
            {
                Defense -= EquippedArmor.Defense;
            }
            EquippedArmor = armor;
            Defense += armor.Defense;
            Console.WriteLine($"{armor.Name} Equiped!");
        }
        // Equip Item
        public bool EquipItem(int index)
        {
            Item item = Inventory.Items[index];
            if (item is Weapon weapon)
            {
                Console.WriteLine($"Equiped: {item}");
                EquipWeapon(weapon);
                return true;
            }
            if (item is Armor armor)
            {
                Console.WriteLine($"Equiped: {item}");
                EquipArmor(armor);
                return true;
            }
            if (index < 0 || index >= Inventory.Items.Count)
            {
                Console.WriteLine("Invalid item index");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return false;
            }
        }
        //Use Item
        public bool UseItem(int index)
        {
            Item item = Inventory.Items[index];
            if (item is Potion)
            {
                Console.WriteLine("Used Potion");
                Potion potion = (Potion)item;
                Heal(potion.HealAmount);
                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
                Console.WriteLine($"Healed {potion.HealAmount} current Health: {Health}");
                Inventory.RemoveItem(item);
                return true;
            }
            if (index < 0 || index >= Inventory.Items.Count)
            {
                Console.WriteLine("Invalid item index");
                return false;
            }
            else 
            {
                Console.WriteLine("Invalid Choice");
                return false;
            }
        }
    }
}
