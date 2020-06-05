using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Ninja : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Ninja(string name) : base(name)
        {
            Speed = 10;
        }

        public override int Attack(Villain target)
        {
            // int completedmg = Health * 5;
            // target.Health -= completedmg;
            // if(target.Health>50)
            // {
            //     target.Health = 0;
            // }
            // Console.WriteLine($"{Name} attacked {target.Name} for {completedmg} damage!");
            // return target.Health;
        }
    }
}