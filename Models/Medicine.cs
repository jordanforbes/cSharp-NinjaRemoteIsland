using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Medicine : IMedicine
    {
        public string Name {get; set;}

        public int Strength {get; set;}

        public Medicine(string name, int str)
        {
            Name = name;
            Strength = str;
        }
        public void Use(Hero target)
        {
            target.ApplyDamage(-5 * Strength);
            Console.WriteLine($"{Name} was used on {target.Name}\n{target.Name}'s health is now {target.Health}!");
        }

        public void Use(Villain target)
        {
            target.ApplyDamage(-5 * Strength);
            Console.WriteLine($"{Name} was used on {target.Name}\n{target.Name}'s health is now {target.Health}!");
        }
    }
}