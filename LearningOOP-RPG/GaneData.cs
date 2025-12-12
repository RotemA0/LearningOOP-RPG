using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP_RPG
{
    
    public static class GaneData 
    {
        static Random random = new Random();
        public static List<Enemy> AllEnemys = new List<Enemy>();
        public static List<Weapon> AllWeapons = new List<Weapon>();
        public static List<Armor> AllArmors = new List<Armor>();
        public static List<Potion> AllPotions = new List<Potion>();

        public static void Inizliaz()
        {
            //Enemys

            //Goblin
            AllEnemys.Add(new Enemy
            {
                Name = "Goblin",
                Level = 1,
                Health = 30,
                MaxHealth = 30,
                Mana = 10,
                MaxMana = 10,
                Attack = 5,
                Defense = 2,
                MagicPower = 3,
                CriticalChance = 0.05,
                ExperienceReward = random.Next(20, 25 + 1),
                GoldDrop = random.Next(10, 20 + 1),
                Description = "A small, green creature with a rusty dagger"
            });

            //Skeleton
            AllEnemys.Add(new Enemy
            {
                Name = "Skeleton",
                Level = 2,
                Health = 40,
                MaxHealth = 40,
                Attack = 8,
                Defense = 3,
                CriticalChance = 0.03,
                ExperienceReward = random.Next(30, 35 + 1),
                GoldDrop = random.Next(15, 25 + 1),
                Description = "Animated bones held together by dark magic"
            });

            //Giant Rat
            AllEnemys.Add(new Enemy
            {
                Name = "Giant Rat",
                Level = 2,
                Health = 35,
                MaxHealth = 35,
                Attack = 6,
                Defense = 1,
                CriticalChance = 0.10,
                ExperienceReward = random.Next(25, 30 + 1),
                GoldDrop = random.Next(5, 15 + 1),
                InflictEffect = new StatusEffect
                {
                    Name = "Poison",
                    Type = StatusEffectType.Poison,
                    Duration = 3,
                    DamagePerTurn = 3
                },
                EffectChance = 20,
                Description = "A diseased rat the size of a small dog"
            });

            //Orc Warrior
            AllEnemys.Add(new Enemy
            {
                Name = "Orc Warrior",
                Level = 5,
                Health = 100,
                MaxHealth = 100,
                Mana = 20,
                MaxMana = 20,
                Attack = 15,
                Defense = 8,
                MagicPower = 5,
                CriticalChance = 0.15,
                ExperienceReward = random.Next(70, 75 + 1),
                GoldDrop = random.Next(30, 50 + 1),
                Description = "A brutish orc wielding a large battleaxe"
            });

            //Dark Mage
            AllEnemys.Add(new Enemy
            {
                Name = "Dark Mage",
                Level = 5,
                Health = 70,
                MaxHealth = 70,
                Mana = 60,
                MaxMana = 60,
                Attack = 8,
                Defense = 4,
                MagicPower = 20,
                CriticalChance = 0.08,
                ExperienceReward = random.Next(75, 80 + 1),
                GoldDrop = random.Next(40, 60 + 1),
                Description = "A robed figure crackling with dark energy"
            });

            //Corrupted Knight
            AllEnemys.Add(new Enemy
            {
                Name = "Corrupted Knight",
                Level = 6,
                Health = 120,
                MaxHealth = 120,
                Mana = 30,
                MaxMana = 30,
                Attack = 18,
                Defense = 12,
                MagicPower = 10,
                CriticalChance = 0.12,
                ExperienceReward = random.Next(85, 90 + 1),
                GoldDrop = random.Next(50, 70 + 1),
                Description = "Once a noble warrior, now consumed by darkness"
            });

            //Demon Hound
            AllEnemys.Add(new Enemy
            {
                Name = "Demon Hound",
                Level = 8,
                Health = 150,
                MaxHealth = 150,
                Mana = 40,
                MaxMana = 40,
                Attack = 25,
                Defense = 10,
                MagicPower = 15,
                CriticalChance = 0.18,
                ExperienceReward = random.Next(140, 150 + 1),
                GoldDrop = random.Next(80, 120 + 1),
                InflictEffect = new StatusEffect
                {
                    Name = "Burn",
                    Type = StatusEffectType.Burn,
                    Duration = 4,
                    DamagePerTurn = 5
                },
                EffectChance = 40,
                Description = "A massive hellhound wreathed in flames"
            });

            //Stone Golem
            AllEnemys.Add(new Enemy
            {
                Name = "Stone Golem",
                Level = 9,
                Health = 200,
                MaxHealth = 200,
                Attack = 20,
                Defense = 20,
                CriticalChance = 0.05,
                ExperienceReward = random.Next(165, 175 + 1),
                GoldDrop = random.Next(100, 150 + 1),
                InflictEffect = new StatusEffect
                {
                    Name = "Stun",
                    Type = StatusEffectType.Stun,
                    Duration = 1,
                    DamagePerTurn = 0
                },
                EffectChance = 15,
                Description = "A towering construct of enchanted stone"
            });

            //Vampire
            AllEnemys.Add(new Enemy
            {
                Name = "Vampire",
                Level = 9,
                Health = 140,
                MaxHealth = 140,
                Mana = 80,
                MaxMana = 80,
                Attack = 22,
                Defense = 12,
                MagicPower = 25,
                CriticalChance = 0.20,
                ExperienceReward = random.Next(170, 180 + 1),
                GoldDrop = random.Next(120, 180 + 1),
                Description = "An elegant but terrifying creature of the night"
            });

            //Death Knight
            AllEnemys.Add(new Enemy
            {
                Name = "Death Knight",
                Level = 12,
                Health = 300,
                MaxHealth = 300,
                Mana = 100,
                MaxMana = 100,
                Attack = 35,
                Defense = 25,
                MagicPower = 30,
                CriticalChance = 0.25,
                ExperienceReward = random.Next(280, 300 + 1),
                GoldDrop = random.Next(200, 300 + 1),
                Description = "A legendary warrior who conquered death itself"
            });

            //Ancient Wyvern
            AllEnemys.Add(new Enemy
            {
                Name = "Ancient Wyvern",
                Level = 13,
                Health = 250,
                MaxHealth = 250,
                Mana = 120,
                MaxMana = 120,
                Attack = 40,
                Defense = 18,
                MagicPower = 35,
                CriticalChance = 0.30,
                ExperienceReward = random.Next(330, 350 + 1),
                GoldDrop = random.Next(250, 400 + 1),
                InflictEffect = new StatusEffect
                {
                    Name = "Burn",
                    Type = StatusEffectType.Burn,
                    Duration = 5,
                    DamagePerTurn = 8
                },
                EffectChance = 50,
                Description = "A massive dragon-like creature with razor-sharp talons"
            });

            //Crypt Lord (Boss)
            AllEnemys.Add(new Enemy
            {
                Name = "The Crypt Lord",
                Level = 10,
                Health = 500,
                MaxHealth = 500,
                Mana = 150,
                MaxMana = 150,
                Attack = 30,
                Defense = 20,
                MagicPower = 40,
                CriticalChance = 0.20,
                ExperienceReward = 500,  // Fixed amount for bosses
                GoldDrop = 500,
                Description = "The ancient ruler of these catacombs, wielding dark necromancy"
            });

            //Ancient Dragon (Final Boss)
            AllEnemys.Add(new Enemy
            {
                Name = "Ancient Dragon",
                Level = 15,
                Health = 800,
                MaxHealth = 800,
                Mana = 200,
                MaxMana = 200,
                Attack = 45,
                Defense = 30,
                MagicPower = 50,
                CriticalChance = 0.35,
                ExperienceReward = 1000,  // Fixed amount for final boss
                GoldDrop = 1000,
                InflictEffect = new StatusEffect
                {
                    Name = "Burn",
                    Type = StatusEffectType.Burn,
                    Duration = 6,
                    DamagePerTurn = 10
                },
                EffectChance = 60,
                Description = "The oldest and most powerful dragon, guardian of ultimate treasure"
            });

            //Apostle (Berserk)
            AllEnemys.Add(new Enemy
            {
                Name = "Apostle",
                Level = 10,
                Health = 200,
                MaxHealth = 200,
                Mana = 50,
                MaxMana = 50,
                Attack = 30,
                Defense = 15,
                MagicPower = 20,
                CriticalChance = 0.22,
                ExperienceReward = random.Next(180, 200 + 1),
                GoldDrop = random.Next(100, 150 + 1),
                Description = "A once-human creature transformed by demonic power. Its true form is a nightmare made flesh."
            });

            //God Hand (Berserk Boss)
            AllEnemys.Add(new Enemy
            {
                Name = "God Hand Member",
                Level = 12,
                Health = 300,
                MaxHealth = 300,
                Mana = 100,
                MaxMana = 100,
                Attack = 35,
                Defense = 20,
                MagicPower = 40,
                CriticalChance = 0.28,
                ExperienceReward = 500,  // Fixed amount for special boss
                GoldDrop = 500,
                Description = "A being of immense power, one of the five members of the God Hand. Their very presence warps reality."
            });
            //--------------------------------------------------------------------------------------------

            //Weapons

            //Rusty Sword
            //Rusty Sword
            AllWeapons.Add(new Weapon
            {
                Name = "Rusty Sword",
                Damage = 5,
                SellValue = 5,
                Description = "A well-worn blade, barely sharp enough to cut",
                RequiredLevel = 1
            });

            //Wooden Staff
            AllWeapons.Add(new Weapon
            {
                Name = "Wooden Staff",
                Damage = 3,
                SellValue = 10,
                Description = "A simple wooden staff for beginner mages",
                RequiredLevel = 1
            });

            //Iron Sword
            AllWeapons.Add(new Weapon
            {
                Name = "Iron Sword",
                Damage = 12,
                SellValue = 50,
                Description = "A reliable iron blade",
                RequiredLevel = 3
            });

            //Steel Dagger
            AllWeapons.Add(new Weapon
            {
                Name = "Steel Dagger",
                Damage = 10,
                SellValue = 60,
                Description = "Fast and deadly, favored by rogues",
                RequiredLevel = 3
            });

            //Apprentice Staff
            AllWeapons.Add(new Weapon
            {
                Name = "Apprentice Staff",
                Damage = 8,
                SellValue = 75,
                Description = "A staff imbued with minor enchantments",
                RequiredLevel = 4
            });

            //War Hammer
            AllWeapons.Add(new Weapon
            {
                Name = "War Hammer",
                Damage = 18,
                SellValue = 90,
                Description = "Heavy and devastating, but slow",
                RequiredLevel = 5,
                Special = "Ignores 25% of enemy defense"
            });

            //Silver Sword
            AllWeapons.Add(new Weapon
            {
                Name = "Silver Sword",
                Damage = 22,
                SellValue = 200,
                Description = "Blessed silver, effective against undead",
                RequiredLevel = 6,
                Special = "+50% damage vs undead enemies"
            });

            //Flame Blade
            AllWeapons.Add(new Weapon
            {
                Name = "Flame Blade",
                Damage = 25,
                SellValue = 250,
                Description = "A sword wreathed in magical flames",
                RequiredLevel = 7,
                Special = "Burns enemies for 5 damage per turn"
            });

            //Mage's Scepter
            AllWeapons.Add(new Weapon
            {
                Name = "Mage's Scepter",
                Damage = 15,
                SellValue = 275,
                Description = "A powerful focus for magical energy",
                RequiredLevel = 8
            });

            //Vorpal Blade
            AllWeapons.Add(new Weapon
            {
                Name = "Vorpal Blade",
                Damage = 30,
                SellValue = 350,
                Description = "A legendary blade that cuts through anything",
                RequiredLevel = 9,
                Special = "Critical hits deal 3× damage instead of 2×"
            });

            //Crypt Lord's Sword
            AllWeapons.Add(new Weapon
            {
                Name = "Crypt Lord's Sword",
                Damage = 40,
                SellValue = 500,
                Description = "The necromantic blade of the Crypt Lord",
                RequiredLevel = 10,
                Special = "20% lifesteal, summon skeleton ally once per battle"
            });

            //Dragon Fang Sword
            AllWeapons.Add(new Weapon
            {
                Name = "Dragon Fang Sword",
                Damage = 60,
                SellValue = 1000,
                Description = "Forged from the fang of an ancient dragon",
                RequiredLevel = 12,
                Special = "Fire damage ignores defense, +100% damage to dragons"
            });

            //Excalibur
            AllWeapons.Add(new Weapon
            {
                Name = "Excalibur",
                Damage = 75,
                SellValue = 2000,
                Description = "The legendary sword of kings",
                RequiredLevel = 15,
                Special = "All stats +10, glows in presence of enemies"
            });

            //Dragon Slayer (Berserk)
            AllWeapons.Add(new Weapon
            {
                Name = "Dragon Slayer",
                Damage = 55,
                SellValue = 0,
                Description = "An enormous, thick, heavy, and far too rough sword. More like a large hunk of iron. This legendary blade has slain countless apostles and demons.",
                RequiredLevel = 10,
                Special = "+50% damage vs demons, Ignores 30% defense, +100% damage to bosses, Attack twice per turn once per battle, Heavy (reduces speed by 10%)"
            });

            //--------------------------------------------------------------------------------------------

            //Armor 

            //Cloth Rags
            AllArmors.Add(new Armor
            {
                Name = "Cloth Rags",
                Defense = 2,
                SellValue = 5,
                Description = "Barely provides any protection",
                RequiredLevel = 1
            });

            //Leather Vest
            AllArmors.Add(new Armor
            {
                Name = "Leather Vest",
                Defense = 5,
                SellValue = 25,
                Description = "Light armor made from hardened leather",
                RequiredLevel = 2
            });

            //Iron Chainmail
            AllArmors.Add(new Armor
            {
                Name = "Iron Chainmail",
                Defense = 10,
                SellValue = 75,
                Description = "Interlocking iron rings provide good protection",
                RequiredLevel = 3
            });

            //Mage Robes
            AllArmors.Add(new Armor
            {
                Name = "Mage Robes",
                Defense = 6,
                SellValue = 90,
                Description = "Enchanted robes that enhance magical abilities",
                RequiredLevel = 4
            });

            //Steel Plate
            AllArmors.Add(new Armor
            {
                Name = "Steel Plate",
                Defense = 15,
                SellValue = 125,
                Description = "Heavy steel armor for maximum protection",
                RequiredLevel = 5,
                Special = "-10% speed but +20% physical damage reduction"
            });

            //Dragon Scale Vest
            AllArmors.Add(new Armor
            {
                Name = "Dragon Scale Vest",
                Defense = 20,
                SellValue = 300,
                Description = "Crafted from the scales of a lesser dragon",
                RequiredLevel = 7
            });

            //Enchanted Plate
            AllArmors.Add(new Armor
            {
                Name = "Enchanted Plate",
                Defense = 25,
                SellValue = 400,
                Description = "Plate armor enhanced with protective runes",
                RequiredLevel = 8
            });

            //Shadow Cloak
            AllArmors.Add(new Armor
            {
                Name = "Shadow Cloak",
                Defense = 18,
                SellValue = 350,
                Description = "Blends with shadows, making you harder to hit",
                RequiredLevel = 8
            });

            //Dark Armor
            AllArmors.Add(new Armor
            {
                Name = "Dark Armor",
                Defense = 35,
                SellValue = 500,
                Description = "The cursed armor of the Crypt Lord",
                RequiredLevel = 10,
                Special = "Regenerate 5 HP per turn in combat"
            });

            //Dragon Scale Armor
            AllArmors.Add(new Armor
            {
                Name = "Dragon Scale Armor",
                Defense = 50,
                SellValue = 1000,
                Description = "Legendary armor from an ancient dragon",
                RequiredLevel = 12,
                Special = "Immune to fire damage, +25% all resistances"
            });

            //Berserker Armor Fragment
            AllArmors.Add(new Armor
            {
                Name = "Berserker Armor Fragment",
                Defense = 15,
                SellValue = 0,
                Description = "A piece of the legendary Berserker Armor. Even a fragment pulses with unstoppable fury.",
                RequiredLevel = 10,
                Special = "Immunity to fear, +10 Attack when Health below 30% for 3 turns"
            });

            //--------------------------------------------------------------------------------------------

            //Potions

            //Minor Health Potion
            AllPotions.Add(new Potion
            {
                Name = "Minor Health Potion",
                HealAmount = 30,
                SellValue = 10,
                Description = "A small vial of red liquid"
            });

            //Health Potion
            AllPotions.Add(new Potion
            {
                Name = "Health Potion",
                HealAmount = 60,
                SellValue = 25,
                Description = "A standard healing potion"
            });

            //Major Health Potion
            AllPotions.Add(new Potion
            {
                Name = "Major Health Potion",
                HealAmount = 150,
                SellValue = 60,
                Description = "A powerful healing elixir"
            });

            //Full Restore Potion
            AllPotions.Add(new Potion
            {
                Name = "Full Restore Potion",
                HealAmount = 9999,  // Use this as flag for "restore all HP and Mana"
                SellValue = 125,
                Description = "Completely restores health and magic",
                Special = "Restores all HP and Mana"
            });

            //Mana Potion
            AllPotions.Add(new Potion
            {
                Name = "Mana Potion",
                ManaAmount = 40,
                SellValue = 20,
                Description = "A blue liquid that restores magical energy"
            });

            //Elixir of Strength
            AllPotions.Add(new Potion
            {
                Name = "Elixir of Strength",
                SellValue = 50,
                Description = "Temporarily increases physical power",
                Special = "+10 Attack for 5 turns"
            });

            //Elixir of Defense
            AllPotions.Add(new Potion
            {
                Name = "Elixir of Defense",
                SellValue = 50,
                Description = "Hardens your skin like stone",
                Special = "+10 Defense for 5 turns"
            });

            //Antidote
            AllPotions.Add(new Potion
            {
                Name = "Antidote",
                SellValue = 15,
                Description = "Neutralizes toxins",
                Special = "Cures poison status effect"
            });

            //--------------------------------------------------------------------------------------------
        }
    }
}
