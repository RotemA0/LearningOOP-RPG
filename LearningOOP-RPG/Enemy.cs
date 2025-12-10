using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    public class Enemy : Character
    {
        public int ExperienceReward = 25;
        public int GoldDrop = 15;

        public string Description = "A small, green creature with a rusty dagger";
        
        
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Experience Reward: {ExperienceReward}");
            Console.WriteLine($"Gold Drop: {GoldDrop}");
        }
    }
}
