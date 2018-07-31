using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfOOP.Equipment.Weapons
{
    public abstract class Weapon : Equipment
    {
        // Field for damage points
        int damagePoints;

        // Property to obtain damage points
        public int DamagePoints
        {
            get
            {
                // reads in value given for damage points
                return this.damagePoints;
            }
            set
            {
                // Check to see if value is between 0 and 10
                if (value >= 0 && value <= 1000)
                {
                    // If damage points are between 0 and 10, assign damage points to field.
                    this.damagePoints = value;
                }
                else
                {
                    // If number is not between 10, throw out of range exception.
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Please enter a positive number between 0 and 1000 for total damage points!");
                }
            }
        }

        public abstract void Attack();

    }
}
