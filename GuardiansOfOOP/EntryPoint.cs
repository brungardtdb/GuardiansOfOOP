using GuardiansOfOOP.Characters;
using GuardiansOfOOP.Characters.Melee;
using GuardiansOfOOP.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace GuardiansOfOOP
{
    class EntryPoint
    {
        static void Main()
        {
            // create new instance of random class
            // to set random character for game
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellcaster = 0;
            
            // boolean value to used to terminate game loop
            bool gameOver = false;
            
            // Create a list containing one of each type of character
            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                new Mage(),
                new Mage()
                //new Necromancer(),
                //new Druid()
            };

            // Create list for melee team
            List<Melee> meleeTeam = new List<Melee>();

            // Create list for Spellcaster team
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            // Loop through each item in "characters" list
            // Assign melee characters to meleeTeam list
            // Assign spellcaster characters to spellTeam list
            foreach (var character in characters)
            {
                if (character is Melee)
                    // If character is of type "melee" add to meleeTeam list
                {
                   meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                    // If character is of type "spellcaster" add to spellcaster list
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            // game loop
            while (!gameOver)
            {
                // 1. Take a random melee
                currentMelee = rng.Next(0, meleeTeam.Count);

                // 2. Take a random spellcaster
                currentSpellcaster = rng.Next(0, spellTeam.Count);

                // 3. Melee attacks spellcaster
                //3.1 Check if character died and remove him from team
                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);

                //3.2 If dead, get another character from the team

                if (!spellTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellcaster]);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!!!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }
                }

                // 4. Spellcaster attacks Melee
                //4.1 Check if character died and remove him from team
                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(), spellTeam[currentSpellcaster].Name);
                                
                //4.2 If dead, get another character from the team

                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster team wins!!!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }



            }

        }
    }
}
