using System;
using System.Collections.Generic;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland {
    class Program {
        static void Main (string[] args) {
            ConsoleBlue ("********NINJA: REMOTE ISLAND********");

            Hero player = PlayerSetup ();

            ConsoleBlue ($"You, {player.Name}, decided to take cruise around the Pacific!  Unfortunately, there was a incident involving a wrong turn and a huge wave.  You blacked out and woke up to find yourself on a remote mysterious island.\n\nNow you must get to the beach so you can send out a distress signal and get back home.  What dangers and mysteries lurk within the jungle island?  Will you make it to the beach safely?  Is this the island with all the dinosaurs?\n\nPress Enter to Start");

            ConsoleKey key = Console.ReadKey (true).Key;
            while (key != ConsoleKey.Enter) 
            {
                key = Console.ReadKey (true).Key;
            }
            Console.WriteLine ("BEGIN YOUR ADVENTURE HERE!!!");

            //write a method that will create other team mates.

            // make a game(while) loop to run your game'
            Hero teammate = AddTeammate ();
            string choice = "0";
            if (choice is "1") {
                // key = Console.ReadKey(true).Key;
                ConsoleBlue ($"You decided to bring the Ninja!\n\nThe Ninja can attack with a shuriken, has super speed\n and steal health from enemies\n\nPress Enter to Start");
            }
            else if (choice is "2") {
                // key = Console.ReadKey(true).Key;
                ConsoleBlue ($"You decided to bring the Wizard!\n\nThe Wizard can shoot fireballs, has super intelligence\n and can lower enemy stats\n\nPress Enter to Start");
            }
            else{
                // key = Console.ReadKey(true).Key;
                ConsoleBlue ($"You decided to bring the Sensei!\n\nThe Sensei can attack with a chop, has super strength\n and can raise his own strength even further\n\nPress Enter to Start");
            }
        }

        static void ConsoleBlue (string text) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine (text);
            Console.ResetColor ();
        }
        static Hero AddTeammate () {
            Console.WriteLine ("Now it's time to choose a teammate!\n Press Enter to Choose:");
            string name = Console.ReadLine ();
            string choice = "0";

            while (choice != "1" && choice != "2" && choice != "3") {
                Console.WriteLine ("Who will you choose as your teammate?\n1. Ninja\n2. Wizard\n3. Sensei");
                choice = Console.ReadLine ();
            }

            switch (choice) {
                case ("1"):
                    Ninja ninjaHero = new Ninja (name);
                    return ninjaHero;
                case ("2"):
                    // Change Ninja to another class of hero.
                    Wizard wizardHero = new Wizard (name);
                    return wizardHero;
                case ("3"):
                    // Change Ninja to another class of hero.
                    Sensei senseiHero = new Sensei (name);
                    return senseiHero;
            }
            return null;
        }
        static Hero PlayerSetup () {
            Console.WriteLine ("What is your name?");

            string name = Console.ReadLine ();
            string choice = "0";

            while (choice != "1" && choice != "2" && choice != "3") {
                Console.WriteLine ("Please type the number of the hero you would ike to be?\n1. Ninja: Highest Speed\n2. Wizard: Highest Intelligence\n3. Sensei: Highest Strength");
                choice = Console.ReadLine ();
            }

            switch (choice) {
                case ("1"):
                    Ninja ninjaHero = new Ninja (name);
                    return ninjaHero;
                case ("2"):
                    // Change Ninja to another class of hero.
                    Wizard wizardHero = new Wizard (name);
                    return wizardHero;
                case ("3"):
                    // Change Ninja to another class of hero.
                    Sensei senseiHero = new Sensei (name);
                    return senseiHero;
            }
            return null;
        }
    }
}