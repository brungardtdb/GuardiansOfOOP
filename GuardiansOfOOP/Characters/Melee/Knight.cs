using GuardiansOfOOP.Equipment.Weapons.Sharp;
using GuardiansOfOOP.Equipment.Armor.Heavy;
using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Weapons;

namespace GuardiansOfOOP.Characters.Melee
{
    public class Knight : Melee
    {        
        // Private readonly class instantiations for default values
        private readonly Armor Default_Body_Armor = new Chainlink();
        private readonly Weapon Default_Weapon = new Sword();

        // Constructors for knight class
        public Knight()
            : this(Consts.Knight.Default_Name, Consts.Knight.Default_Level)
        {

        }

        public Knight(string name, int level)
            : this(name, level, Consts.Knight.Default_Health_Points)
        {

        }

        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Knight.Default_Faction;
            base.AbilityPoints = Consts.Knight.Default_Ability_Points;
            base.BodyArmor = Default_Body_Armor;
            base.Weapon = Default_Weapon;
            base.IsAlive = true;
            base.Scores = 0;
        }

        // attack method
        public int KickButts()
        {
            return base.Weapon.DamagePoints + 10;
        }

        // special attack method
        public int PunchaYoBuns()
        {
            return base.Weapon.DamagePoints + 20;
        }

        // defense method
        public int Mathmatical()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            // call method within knight class
            // to be used as attack method
            return this.KickButts();
        }

        public override int SpecialAttack()
        {
            // call method within knight class
            // to be used as special attack method
            return this.PunchaYoBuns();
        }

        public override int Defend()
        {
            // call method within knight class
            // to be used as defend method
            return this.Mathmatical();
        }        
    }
}
