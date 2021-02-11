using System;

namespace HumanProject.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100)
        {
            name = Name;
        }

        public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 175, hp)
        {
            name = Name;
            str = Strength;
            intel = Intelligence;
            hp = Health;
        }

        public override int Attack(Human target)
        {
            // Give Damage to Dexterity
            int dmg = Dexterity * 5;

            // Give Random Damage 
            Random rand = new Random();
            if (rand.Next(1, 5) == 1)
            {
                dmg += 10;
            }

            target.addDmg(dmg);
            Console.WriteLine($"{Name} is attacking {target.Name} adding {dmg} damage!\n Current Target HP {target.health}, Current HP {Health}.");
            return target.health;
        }

        public int Steal(Human target)
        {
            target.addDmg(5);
            Health += 5;
            Console.WriteLine($"{Name} Steals 5 health from {target.Name}!");
            return Health;
        }
    }
}