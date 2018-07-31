using GuardiansOfOOP.Equipment.Armor;
using GuardiansOfOOP.Equipment.Armor.Leather;
using GuardiansOfOOP.Equipment.Weapons;
using GuardiansOfOOP.Equipment.Weapons.Blunt;

namespace GuardiansOfOOP.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        // Private readonly class instantiations for default values
        private readonly Armor Default_Body_Armor = new LightLeatherVest();
        private readonly Weapon Default_Weapon = new Staff();

        // Constructors for Necromancer class
        public Necromancer()
            : this(Consts.Necromancer.Default_Name, Consts.Necromancer.Default_Level)
        {

        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.Default_Health_Points)
        {

        }

        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Necromancer.Default_Faction;
            base.ManaPoints = Consts.Necromancer.Default_Ability_Points;
            base.BodyArmor = Default_Body_Armor;
            base.Weapon = Default_Weapon;
        }

        // attack method
        public int KingLich()
        {
            return base.Weapon.DamagePoints + 10;
        }

        // special attack method
        public int SoulStealer()
        {
            return base.Weapon.DamagePoints + 20;
        }

        // defense method
        public int DreamPlague()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            // call method within necromancer class
            // to be used as attack method
            return this.KingLich();
        }

        public override int SpecialAttack()
        {
            // call method within necromancer class
            // to be used as special attack method
            return this.SoulStealer();
        }

        public override int Defend()
        {
            // call method within necromancer class
            // to be used as defend method
            return this.DreamPlague();
        }
       
    }
}
