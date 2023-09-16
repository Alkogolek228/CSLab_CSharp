using GameUnits;

namespace lb6
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Grom Hellscream", 100, 20);
            Mage mage = new Mage("Jaina Proudmoore", 80, 15);

            Console.WriteLine($"{warrior.Name} ({warrior.GetType().Name}) has {warrior.Health} health and deals {warrior.Damage} damage.");
            Console.WriteLine($"{mage.Name} ({mage.GetType().Name}) has {mage.Health} health and deals {mage.Damage} damage.");

            mage.Attack(warrior);
            warrior.SpecialAbility(mage);
            mage.SpecialAbility(warrior);
        }
    }
}