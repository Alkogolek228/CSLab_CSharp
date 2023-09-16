using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Unit(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public virtual void Attack(Unit enemy)
        {
            enemy.Health -= Damage;
            Console.WriteLine($"{Name} attacks {enemy.Name} and deals {Damage} damage. {enemy.Name} has {enemy.Health} health remaining.");
        }

        public abstract void SpecialAbility(Unit enemy);
    }

    public sealed class Warrior : Unit
    {

        public Warrior(string name, int health, int damage) : base(name, health, damage)
        {

        }

        public override void SpecialAbility(Unit enemy)
        {
            Damage *= 2;
            Attack(enemy);
            Damage /= 2;
            Console.WriteLine($"{Name} uses their special ability and deals {Damage} damage to {enemy.Name}. {enemy.Name} has {enemy.Health} health remaining.");
        }
    }

    public class Mage : Unit
    {
        public Mage(string name, int health, int damage) : base(name, health, damage)
        {

        }

        public override void SpecialAbility(Unit enemy)
        {
            Health += Damage;
            Console.WriteLine($"{Name} uses their special ability and heals themselves for {Damage} health. {Name} now has {Health} health.");
        }
    }
}



