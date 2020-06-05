using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Dinosaur : Villain
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a dinosaur.");
        }

        public Dinosaur(string name) : base(name)
        {
            Strength = 10;
        }

                public override void Attack(Hero target)
        {
            // Build Attack method
            Random rand = new Random();
            // give me a random number between 1 and 15
            int roll = rand.Next(1,16);
            int damage = 0;
            if(roll == 15) 
            {
                // critical success!
                damage = (int) 1.5 * Strength;
                Console.WriteLine($"{Name} bites {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Strength;
                Console.WriteLine($"{Name} chomps on {target.Name}! Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} tried to bite {target.Name} but missed!");
            }
            target.Health -= damage;
        }

    }
}