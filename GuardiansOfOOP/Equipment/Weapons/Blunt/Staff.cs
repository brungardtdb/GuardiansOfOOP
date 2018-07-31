using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfOOP.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        

        public Staff()
        {
            this.DamagePoints = 90;
        }

        public override void Attack()
        {
            this.Empower();
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
