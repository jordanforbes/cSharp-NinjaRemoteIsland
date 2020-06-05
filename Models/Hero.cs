using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public abstract class Hero
    {
        public string Name;
        public int Intelligence;
        public int Strength;
        public int Speed;
        protected int health;

        public Hero(string name)
        {
            Name = name;
            Intelligence = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
        }

        public abstract void SayName();

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nIntelligence: {Intelligence}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }

        public virtual void Attack(Villain target)
        {
            // Build Attack method
            Random rand = new Random();
            // give me a random number between 1 and 15
            int roll = rand.Next(1,16);
            int damage = 0;
            if(roll == 15) 
            {
                // critical success!
                damage = (int) 1.5 * (Attack - (target.health/3));
                Console.WriteLine($"Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Attack - (target.health/3);
                Console.WriteLine($"Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} missed the mark!");
            }
            target.health -= damage;
        }
    }
}