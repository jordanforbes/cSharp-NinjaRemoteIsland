using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Wizard : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a wizard.");
        }

        public Wizard(string name) : base(name)
        {
            Intelligence = 10;
        }

        public override void Attack(Villain target)
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
                Console.WriteLine($"{Name} shoots a giant fireball at {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Intelligence;
                Console.WriteLine($"{Name} shoots a fireball at {target.Name}! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} missed the mark!");
            }
            target.health -= damage;
        }

        public void Magic(Villain target)
        {
            // Build Magic method
            if( target is Dinosaur)
            {
                target.Strength -=1;
            }
            else if(target is Bandit)
            {
                target.Speed -=1;
            }
            else
            {
                target.Intelligence -=1;
            }
        }
    }
}