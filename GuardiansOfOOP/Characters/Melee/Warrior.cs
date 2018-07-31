using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Armor.Heavy;
using GuardiansOfOOP.Equipment.Weapons;
using GuardiansOfOOP.Equipment.Weapons.Blunt;

namespace GuardiansOfOOP.Characters.Melee
{
    public class Warrior : Melee
    {       
        // Private readonly class instantiations for default values
        private readonly Armor Default_Body_Armor = new Chainlink();
        private readonly Weapon Default_Weapon = new Hammer();           

        // Constructors for warrior class
        public Warrior()
            : this(Consts.Warrior.Default_Name, Consts.Warrior.Default_Level)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.Default_Health_Points)
        {

        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Warrior.Default_Faction;
            base.AbilityPoints = Consts.Warrior.Default_Ability_Points;
            base.BodyArmor = Default_Body_Armor;
            base.Weapon = Default_Weapon;
            base.IsAlive = true;
            base.Scores = 0;
        }

        // attack method
        public int KnuckleSandwich()
        {
            return base.Weapon.DamagePoints + 10;
        }

        // special attack method
        public int Stretch()
        {
            return base.Weapon.DamagePoints + 20;
        }

        // defense method
        public int TurnLumpy()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            // call method within warrior class
            // to be used as attack method
            return this.KnuckleSandwich();
        }

        public override int SpecialAttack()
        {
            // call method within warrior class
            // to be used as special attack method
           return this.Stretch();
        }

        public override int Defend()
        {
            // call method within warrior class
            // to be used as defend method
            return this.TurnLumpy();
        }

    }
}

