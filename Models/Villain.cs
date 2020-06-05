using System;
using System.Collections.Generic;

namespace cSharp_NinjaRemoteIsland.Models
{
    public abstract class Villain
    {
        public string Name;
        public int Intelligence;
        public int Strength;
        public int Speed;
        public int health;

        public int Health
        {
            get;set;
        }

        // public string 
        // public string GetInfo()
        // {
        //     return $"{Name} Intelligence: {Intelligence}.  Strength: {Strength}, Speed: {Speed} Health Available:{Health}";
        // }
        public Villain(string name)
        {
            Name = name;
            Intelligence = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
            this.MedicineBag = new List<IMedicine>();
        }

        public abstract void SayName();

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nIntelligence: {Intelligence}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }

        List<IMedicine> MedicineBag = new List<IMedicine>();

public void ApplyDamage(int Damage)
        {
            health -= Damage;
        }

        public virtual void Attack(Hero target)
        {
            // Build Attack method
            Random rand = new Random();
            // give me a random number between 1 and 15
            int roll = rand.Next(1,16);
            int damage = 0;
            if(roll == 15) 
            {
                // critical success!
                damage = (int) 1.5 * Strength;
                Console.WriteLine($"Critical Hit! {target.Name} takes {damage} damage!");
            } 
            else if(roll > 4)
            {
                // just a hit
                damage = Strength;
                Console.WriteLine($"Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                // miss
                Console.WriteLine($"Miss! {Name} missed the mark!");
            }
            target.Health -= damage;
        }
    }
}