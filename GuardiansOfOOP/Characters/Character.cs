using System;
using GuardiansOfOOP.Enums;
using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Weapons;
using GuardiansOfOOP.Interfaces;

namespace GuardiansOfOOP.Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        // Fields for character class
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private bool isAlive;
        private int scores;

        // Class instantiation for armor and weapons
        private Armor bodyArmor;
        private Weapon weapon;


        // property to obtain faction
        public Faction Faction
        {
            get
            {
                // reads in value given for faction
                return this.faction;
            }
            set
            {

                // assign value to faction
                this.faction = value;

            }
        }

        // property to obtain health points
        public int HealthPoints
        {
            get
            {
                // reads in value given for health points
                return this.healthPoints;
            }
            set
            {
                // Check to see if value is between 0 and 10
                if (value >= 0 && value <= 1000)
                {
                    // If health points are between 0 and 10, assign health points to field.
                    this.healthPoints = value;
                }
                else
                {
                    // If number is not between 10, throw out of range exception.
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Please enter a positive number between 0 and 1000 for {name}'s health points!");
                }
            }
        }

        // property to obtain level
        public int Level
        {
            get
            {
                // reads in value given for level
                return this.level;
            }
            set
            {
                // Check to see if value is between 0 and 10
                if (value >= 0 && value <= 10)
                {
                    // If level is between 0 and 10, assign ability points to field.
                    this.level = value;
                }
                else
                {
                    // If number is not between 10, throw out of range exception.
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Please enter a positive number between 0 and 10 for {name}'s level!");
                }
            }
        }

        // property to obtain character's name
        public string Name
        {
            get
            {
                // reads in value given for name
                return this.name;
            }
            set
            {
                // Check to see if value is not null
                if (value != null)
                {
                    // If value is not null
                    this.name = value;
                }
                else
                {
                    // If name string is empty, throw arguement null exception.
                    throw new ArgumentNullException(string.Empty, "Please enter a name for your character!");
                }
            }
        }

        // property to obtain character's body armor
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        // property to obtain character's body weapon
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        // property to check character's status (are they alive?)
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        // property to track character's score
        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }

        // method that allows character to attack oponent
        public abstract int Attack();

        // special attack method
        public abstract int SpecialAttack();

        // method for character defense
        public abstract int Defend();

        // method used for characters taking damage in combat
        public void TakeDamage(int damage, string attackerName)
        {
            // if damage is greater than defense
            if (this.Defend() < damage)
            {
                // remove damage - defense from health points
                this.healthPoints = this.healthPoints - damage + this.Defend();

                // if healthpoints are less than or equal to zero
                if (this.healthPoints <= 0)
                {
                    // character is dead
                    this.isAlive = false;
                }
            }
            else // if damage was not greater than defense
            {
                // print message showing damage wasn't high enough
                Console.WriteLine("Damage was not high enough");
            }

            // if character is no longer alive
            if (!this.isAlive)
            {
                // print message showing damage received and who killed character
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName}, and is now dead!");
            }
            else
            // if character is still alive
            {
                // print message showing damage received and identity of attacker
                Console.WriteLine($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} health points!");
            }

        }

        // Method to increase level for every 10th battle won
        public void WonBattle()
        {
            this.scores++;

            if(this.scores % 10 == 0)
            {
                this.level++;
            }
        }
       
    }

    
}
