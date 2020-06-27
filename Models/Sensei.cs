using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class Sensei : Hero {
        public override void SayName () {
            Console.WriteLine ($"Hello My name is {Name}, and I'm a ninja.");
        }

        public void Chop () {

        }

        public Sensei (string name) : base (name) {
            Strength = 10;
        }

        public override void Attack (Villain target) {
            Random rand = new Random ();
            // give me a random number between 1 and 20
            int roll = rand.Next (1, 16);
            int damage = 0;
            if (roll == 15) {
                // critical success!
                damage = (int) 1.5 * Strength;
                Console.WriteLine ($"{Name} slaps {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } else if (roll > 4) {
                // just a hit
                damage = Strength;
                Console.WriteLine ($"{Name} chops {target.Name}! {target.Name} takes {damage} damage!");
            } else {
                // miss
                Console.WriteLine ($"{Name} tries to chop {target.Name}! Miss! {Name} missed the mark!");
            }
            target.health -= damage;
        }

        public void Meditate () {
            Strength += 2;
            Console.WriteLine ($"{Name} meditated, {Name}'s Strength raised to {Strength}");
        }
    }
}