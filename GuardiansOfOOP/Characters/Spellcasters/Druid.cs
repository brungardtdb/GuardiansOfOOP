using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Armor.Leather;
using GuardiansOfOOP.Equipment.Weapons;
using GuardiansOfOOP.Equipment.Weapons.Blunt;

namespace GuardiansOfOOP.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        // Private readonly class instantiations for default values
        private readonly Armor Default_Body_Armor = new LightLeatherVest();
        private readonly Weapon Default_Weapon = new Staff();

         // Constructors for Druid class
        public Druid()
            : this(Consts.Druid.Default_Name, Consts.Druid.Default_Level)
        {

        }

        public Druid(string name, int level)
            : this(name, level, Consts.Druid.Default_Health_Points)
        {

        }

        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Druid.Default_Faction;
            base.ManaPoints = Consts.Druid.Default_Mana_Points;
            base.BodyArmor = Default_Body_Armor;
            base.Weapon = Default_Weapon;
            base.IsAlive = true;
            base.Scores = 0;
        }

        // attack method
        public int MagicManCan()
        {
            return base.Weapon.DamagePoints + 10;
        }

        // special attack method
        public int UltimatePrank()
        {
            return base.Weapon.DamagePoints + 20;
        }

        // defense method
        public int GetOnYourNerves()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            // call method within druid class
            // to be used as attack method
            return this.MagicManCan();
        }

        public override int SpecialAttack()
        {
            // call method within druid class
            // to be used as special attack method
            return this.UltimatePrank();
        }

        public override int Defend()
        {
            // call method within druid class
            // to be used as defend method
            return this.GetOnYourNerves();
        }        
    }
}
