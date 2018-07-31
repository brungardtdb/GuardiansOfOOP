using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfOOP.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
       public Sword()
        {
            this.DamagePoints = 70;
        }

        public override void Attack()
        {
            this.BloodThirst();
        }

        public void BloodThirst()
        {
            throw new NotImplementedException();
        }
    }
}
