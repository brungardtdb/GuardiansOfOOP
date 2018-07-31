using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Armor.Leather;
using GuardiansOfOOP.Equipment.Weapons;
using GuardiansOfOOP.Equipment.Weapons.Sharp;

namespace GuardiansOfOOP.Characters.Melee
{
    public class Assassin : Melee
    {   
        // Private readonly class instantiations for default values
        private readonly Armor Default_Body_Armor = new LightLeatherVest();
        private readonly Weapon Default_Weapon = new Axe();        
       
        // Constructors for assassin class
        public Assassin()
            : this(Consts.Assassin.Default_Name, Consts.Assassin.Default_Level)
        {

        }

        public Assassin(string name, int level)
            : this(name, level, Consts.Assassin.Default_Health_Points)
        {

        }

        public Assassin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Assassin.Default_Faction;
            base.AbilityPoints = Consts.Assassin.Default_Ability_Points;
            base.BodyArmor = Default_Body_Armor;
            base.Weapon = Default_Weapon;
            base.IsAlive = true;
            base.Scores = 0;
        }

        // attack method
        public int Scorch()
        {
            return base.Weapon.DamagePoints + 10;
        }

        // special attack method
        public int Arson()
        {
            return base.Weapon.DamagePoints + 20;
        }

        // defense method
        public int CharredRemains()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            // call method within assassin class
            // to be used as attack method
            return this.Scorch();
        }

        public override int SpecialAttack()
        {
            // call method within assassin class
            // to be used as special attack method
            return this.Arson();
        }

        public override int Defend()
        {
            // call method within assassin class
            // to be used as defend method
            return this.CharredRemains();
        }
        
    }
}
         
