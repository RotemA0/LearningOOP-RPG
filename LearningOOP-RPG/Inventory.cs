using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaudeRPG
{
    public class Inventory
    {
        public List<Item> Items = new List<Item>();

        //Add item
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        //Remove item
        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
        //Display items
        public void DisplayInventory()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Inventory is empty!");
                return;
            }

            Console.WriteLine("=== INVENTORY ===");
            for (int i = 0; i < Items.Count; i++)
            {
                Item item = Items[i];

                if (item is Weapon weapon)
                {
                    Console.WriteLine($"{i + 1}. {weapon.Name} (Weapon) - Damage: +{weapon.Damage}");
                }
                else if (item is Armor armor)
                {
                    Console.WriteLine($"{i + 1}. {armor.Name} (Armor) - Defense: +{armor.Defense}");
                }
                else if (item is Potion potion)
                {
                    Console.WriteLine($"{i + 1}. {potion.Name} (Potion) - Heals: {potion.HealAmount} HP");
                }
            }
        }


    }
}
