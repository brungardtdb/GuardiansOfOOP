using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfOOP.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        
        public Axe()
        {
            this.DamagePoints = 50;
        }

        public override void Attack()
        {
            this.HackNSlash();
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
