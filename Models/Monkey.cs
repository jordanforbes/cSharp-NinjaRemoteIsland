using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Monkey : Villain
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a monkey.");
        }

        public Monkey(string name) : base(name)
        {
            Intelligence = 10;
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
                damage = (int) 1.5 * Intelligence;
                Console.WriteLine($"{Name} throws a coconut at {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Intelligence;
                Console.WriteLine($"{Name} throws a banana at {target.Name}! Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} missed the mark!");
            }
            target.Health -= damage;
        }
    }
}