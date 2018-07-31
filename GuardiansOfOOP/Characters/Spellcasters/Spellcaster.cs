using System;

namespace GuardiansOfOOP.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {

        // Fields for Melee class
        int manaPoints;

        // property to obtain ability points
        public int ManaPoints
        {
            get
            {
                // reads in value given for ability points
                return this.manaPoints;
            }
            set
            {
                // Check to see if value is between 0 and 1000
                if (value >= 0 && value <= 1000)
                {
                    // If ability points are between 0 and 1000, assign ability points to field.
                    this.manaPoints = value;
                }
                else
                {
                    // If number is not between 1000, throw out of range exception.
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Please enter a positive number between 0 and 1000 for {this.Name}'s ability points!");
                }
            }
        }
    }
}
