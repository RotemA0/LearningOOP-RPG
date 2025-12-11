using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    internal class Program
    {

        static void Main(string[] args)
        {

        }
        public static void Combat(Player player, Enemy enemy, bool allowCombat)
        {
            while (player.IsAlive() && enemy.IsAlive())
            {
                player.AttackEnemy(enemy);
                if (!enemy.IsAlive())
                {
                    player.Experience += enemy.ExperienceReward;
                    player.Gold += enemy.GoldDrop;
                    Console.WriteLine("Enemy defeated!");
                    break;  
                }

                enemy.AttackEnemy(player);
                if (!player.IsAlive())
                {
                    Console.WriteLine("Player defeated!");
                    break;
                }
            }
        }
    }
    
}
