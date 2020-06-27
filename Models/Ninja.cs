using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class Ninja : Hero {
        public override void SayName () {
            Console.WriteLine ($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Ninja (string name) : base (name) {
            Speed = 10;
        }

        public override void Attack (Villain target) {
            Random rand = new Random ();
            // give me a random number between 1 and 20
            int roll = rand.Next (1, 16);
            int damage = 0;
            if (roll == 15) {
                // critical success!
                damage = (int) 1.5 * Speed;
                Console.WriteLine ($"{Name} throws Shuriken at {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } else if (roll > 4) {
                // just a hit
                damage = Speed;
                Console.WriteLine ($"{Name} throws Shuriken at {target.Name}! {target.Name} takes {damage} damage!");
            } else {
                // miss
                Console.WriteLine ($"{Name} throws Shuriken at {target.Name}! Miss! {Name} missed the mark!");
            }
            target.health -= damage;
        }

        public int Steal(Villain target)
        {
            int stole = health * 5;
            target.health -= stole;
            health += stole;
            Console.WriteLine($"{Name} stole {stole} health from {target.Name}!");
            return target.health;
        }

    }
}