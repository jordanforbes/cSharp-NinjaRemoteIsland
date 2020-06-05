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
    }
}