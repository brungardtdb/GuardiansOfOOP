using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfOOP.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {      

        public Hammer()
        {
            base.DamagePoints = 30;
        }

        public override void Attack()
        {
            this.Stun();
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
