using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Sensei : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a sensei.");
        }

        public Sensei(string name) : base(name)
        {
            Strength = 10;
        }
    }
}