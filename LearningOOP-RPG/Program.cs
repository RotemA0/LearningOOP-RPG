using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
        public static void NormalCombat(Player player, Enemy enemy, int item)
        {
            Random random = new Random();

            Console.WriteLine($"{enemy.Name} Apeared");
            while (player.IsAlive() && enemy.IsAlive())
            {
                //Player choice
                Console.WriteLine("=== Combat Menu ===");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Item (Potion/Elixir)");
                Console.WriteLine("3. Defend (Reduce Damage for one turn)");
                Console.WriteLine("4. Run away");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        player.AttackEnemy(enemy);
                        break;
                    case 2:
                        player.UseItem(item);
                        break;
                    case 3:
                        player.CurrentDefense += player.CurrentDefense / 2;
                        break;
                    case 4:
                        int chanceToRun = random.Next(1, 100 + 1);
                        if (chanceToRun < 55)
                        {
                            Console.WriteLine("Failed to run away");
                        }
                        else
                        {
                            Console.WriteLine("Run away succsfully!");
                            return;
                        }
                        break;
                }
                int enemyChoice = random.Next(1, 2 + 1);
                switch (enemyChoice)
                {
                    case 1:
                        enemy.AttackEnemy(player);
                        break;
                    case 2:
                        enemy.CurrentDefense += enemy.CurrentDefense / 2;
                        break;
                }

            }
            if (player.IsAlive() == true && enemy.IsAlive() == false)
            {
                Console.WriteLine($"{player.Name} was Defeted {enemy.Name}");
                player.Gold += enemy.GoldDrop;
                player.Experience += enemy.ExperienceReward;
            }
            else
            {
                Console.WriteLine($"{player.Name} was Defeted by {enemy.Name}");
            }
        }
    }
}
