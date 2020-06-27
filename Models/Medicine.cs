using System;
using System.Collections.Generic;

namespace cSharp_NinjaRemoteIsland.Models {
    public class Medicine : IMedicine {
        public string Name { get; set; }

        public int Str { get; set; }

        public Medicine (string name, int str) {
            Name = name;
            Str = str;
        }

        public void Use (Hero target) {
            target.ApplyDamage (-5 * Str);
            Console.WriteLine ($"{Name} was used on {target.Name}\n{target.Name}'s health is now {target.Health}");

        }

        public void Use (Villain target) {
            target.ApplyDamage (-5 * Str);
            Console.WriteLine ($"{Name} was used on {target.Name}\n{target.Name}'s health is now {target.health}");

        }
    }
}