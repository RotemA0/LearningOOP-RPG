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
        
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Experience: {Experience}/{ExperienceToNextLevel}");
            Console.WriteLine($"Gold: {Gold}");
        }

    }
}
