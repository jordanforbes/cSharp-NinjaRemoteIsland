using System;

namespace cSharp_NinjaRemoteIsland.Models {
    public class Monkey : Villain {
        public override void SayName () {
            Console.WriteLine ($"Hello My name is {Name}, and I'm a ninja.");
        }


        public Monkey (string name) : base (name) {
            Intelligence = 10;
        }

        public override void Attack (Hero target) {
            Random rand = new Random ();
            // give me a random number between 1 and 20
            int roll = rand.Next (1, 16);
            int damage = 0;
            if (roll == 15) {
                // critical success!
                damage = (int) 1.5 * Speed;
                Console.WriteLine ($"{Name} throws Coconut at {target.Name}! Critical Hit! {target.Name} takes {damage} damage!");
            } else if (roll > 4) {
                // just a hit
                damage = Speed;
                Console.WriteLine ($"{Name} throws Banana at {target.Name}! {target.Name} takes {damage} damage!");
            } else {
                // miss
                Console.WriteLine ($"{Name} throws Banana at {target.Name}! Miss! {Name} missed the mark!");
            }
            target.Health -= damage;
        }

    }
}