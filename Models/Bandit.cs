using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Bandit : Villain
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a bandit.");
        }

        public Bandit(string name) : base(name)
        {
            Speed = 10;
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
                damage = (int) 1.5 * Speed;
                Console.WriteLine($"{Name} stabbed {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Speed;
                Console.WriteLine($"{Name} slashes {target.Name}! Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} missed!");
            }
            target.Health -= damage;
        }

    }
}