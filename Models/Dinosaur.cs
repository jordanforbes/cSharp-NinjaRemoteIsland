using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class Dinosaur : Villain {
        public override void SayName () {
            Console.WriteLine ($"Hello My name is {Name}, and I'm a ninja.");
        }


        public Dinosaur (string name) : base (name) {
            Strength = 10;
        }

        public override void Attack (Hero target) {
            Random rand = new Random ();
            // give me a random number between 1 and 20
            int roll = rand.Next (1, 16);
            int damage = 0;
            if (roll == 15) {
                // critical success!
                damage = (int) 1.5 * Strength;
                Console.WriteLine ($"{Name} Chews on {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } else if (roll > 4) {
                // just a hit
                damage = Strength;
                Console.WriteLine ($"{Name} Bites {target.Name}! {target.Name} takes {damage} damage!");
            } else {
                // miss
                Console.WriteLine ($"{Name} Tries to bite {target.Name}! Miss! {Name} missed the mark!");
            }
            target.Health -= damage;
        }

    }
}