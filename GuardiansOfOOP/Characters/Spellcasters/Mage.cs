using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Armor.Light;
using GuardiansOfOOP.Equipment.Weapons;
using GuardiansOfOOP.Equipment.Weapons.Blunt;

namespace GuardiansOfOOP.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        // Private readonly class instantiations for default values
        private readonly Armor Default_Body_Armor = new ClothRobe();
        private readonly Weapon Default_Weapon = new Staff();

        // Constructors for Mage class
        public Mage()
            : this(Consts.Mage.Default_Name, Consts.Mage.Default_Level)
        {

        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.Default_Health_Points)
        {

        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Mage.Default_Faction;
            base.ManaPoints = Consts.Mage.Default_Mana_Points;
            base.BodyArmor = Default_Body_Armor;
            base.Weapon = Default_Weapon;
            base.IsAlive = true;
            base.Scores = 0;
        }

        // attack method
        public int Freeze()
        {
            return base.Weapon.DamagePoints + 10;
        }

        // special attack method
        public int Kidnapp()
        {
            return base.Weapon.DamagePoints + 20;
        }

        // defense method
        public int Creep()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            // call method within mage class
            // to be used as attack method
            return this.Freeze();
        }

        public override int SpecialAttack()
        {
            // call method within mage class
            // to be used as special attack method
            return this.Kidnapp();
        }

        public override int Defend()
        {
            // call method within mage class
            // to be used as defend method
            return this.Creep();
        }        
    }
}
