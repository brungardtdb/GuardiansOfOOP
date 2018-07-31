using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfOOP.Equipment.Armor
{
    public abstract class Armor : Equipment
    {
        // Field for armor points
        int armorPoints;

        // Property to obtain armor points
        public int ArmorPoints
        {
            get
            {
                // reads in value given for armor points
                return this.armorPoints;
            }
            set
            {
                // Check to see if value is between 0 and 10
                if (value >= 0 && value <= 1000)
                {
                    // If armor points are between 0 and 10, assign armor points to field.
                    this.armorPoints = value;
                }
                else
                {
                    // If number is not between 10, throw out of range exception.
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Please enter a positive number between 0 and 1000 for total armor points!");
                }
            }
        }

       

    }
}
