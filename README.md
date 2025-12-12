# Learning OOP RPG

A text-based RPG game built in C# while learning Object-Oriented Programming concepts through hands-on development.

## About
This project is a comprehensive 12-phase learning journey that demonstrates core OOP concepts including classes, inheritance, polymorphism, encapsulation, and advanced design patterns through a playable turn-based RPG with Berserk manga theming.

## Current Progress: Phase 6 (50% Complete)

### ✅ Completed Features (Phases 1-5)
- **Phase 1-2:** Character system with base class and inheritance
  - Character base class with Player and Enemy derived classes
  - Stat management (Health, Attack, Defense, Mana, Magic Power)
  - Combat-ready character framework

- **Phase 3:** Turn-based combat system
  - Attack calculations with defense reduction
  - Critical hit system
  - Victory rewards (experience and gold)
  - Combat loop with player/enemy turns

- **Phase 4:** Item hierarchy and inventory
  - Item base class with Weapon, Armor, and Potion derived classes
  - Inventory system with Add/Remove/Display functionality
  - Equipment system for weapons and armor

- **Phase 5:** Advanced inventory methods
  - UseItem() - Consume potions with healing
  - EquipWeapon() - Swap weapons without stat stacking
  - EquipArmor() - Swap armor pieces properly
  - EquipItem() - Smart type-checking equipment method

### 🔨 In Progress (Phase 6)
- **Status Effects System:**
  - StatusEffect class with enum types (Poison, Burn, Stun, Buffs)
  - ApplyStatusEffects() method in Character class
  - Damage-over-time effects (Poison, Burn)
  - Stun mechanics
  - Duration tracking and automatic cleanup

- **GameData Class:**
  - Centralized data storage for all game entities
  - 14 enemies with status effects and critical chances
  - 14 weapons with special abilities
  - 11 armor pieces
  - 8 consumable potions
  - Easy spawning system for consistent game data

### 📋 Planned Features (Phases 7-12)
- **Phase 7:** Dungeon system with room navigation
- **Phase 8:** Shop and economy system
- **Phase 9:** Leveling and progression system
- **Phase 10:** Save/Load functionality
- **Phase 11:** Boss battles with special mechanics
- **Phase 12:** Polish, achievements, and Berserk quest chain

### 🗡️ Special Content: Berserk Theme
- **Dragon Slayer** legendary weapon (Quest reward)
- **Apostle** demon-type enemies
- **God Hand** special boss encounter
- **Berserker Armor Fragment** legendary equipment
- "The Black Swordsman's Trial" side quest chain

## What I've Learned

### Core OOP Concepts
- Class design and object composition
- Inheritance with base and derived classes
- Method overriding using `virtual` and `override`
- Polymorphism through type checking (`is` keyword)
- Encapsulation with fields and methods

### Advanced Concepts
- Object initialization syntax
- Type checking and casting patterns
- List management and iteration
- Enum types for type-safe constants
- Static classes for shared data
- Lambda expressions for list operations
- Method responsibility separation

### Design Patterns
- Base class abstraction for shared behavior
- Derived classes for specialization
- Object composition (items within inventory)
- Centralized data management (GameData class)

### C# Skills
- Collections (List<T>)
- Random number generation
- Control flow (loops, conditionals)
- Method parameters and return types
- Object-oriented project structure

## Project Stats
- **~500+ lines of code**
- **9 classes** (Character, Player, Enemy, Item, Weapon, Armor, Potion, StatusEffect, GameData)
- **47 game entities** configured (enemies, weapons, armor, potions)
- **~7-8 hours** of development time (estimated remaining)
- **GitHub repository** initialized

## Tech Stack
- C# .NET
- Console Application
- Visual Studio 2022
- Git/GitHub for version control

## How to Run
1. Clone the repository
2. Open solution in Visual Studio
3. Press F5 to run
4. Follow on-screen prompts to battle enemies

## Development Philosophy
This project prioritizes hands-on learning through implementation. The focus is on understanding OOP principles by building real game systems, iterating on design, and solving problems independently rather than following tutorials.

---

*"An enormous, thick, heavy, and far too rough sword. More like a large hunk of iron."* - Dragon Slayer description