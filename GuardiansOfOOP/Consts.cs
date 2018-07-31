using GuardiansOfOOP.Enums;
using System;


namespace GuardiansOfOOP
{
    // Dedicated constants file
    public static class Consts
    {
       
                
        // Constants for Melee characters

        public static class Warrior
        {
            // Public constant fields for default values (Warrior)
            public const string Default_Name = "Jake the DWG";
            public const int Default_Level = 9;
            public const int Default_Health_Points = 100;
            public const Faction Default_Faction = Faction.Melee;
            public const int Default_Ability_Points = 175;
        }
           
        public static class Assassin
        {
            // Public constant fields for default values (Assassin)
            public const string Default_Name = "Scorcho";
            public const int Default_Level = 11;
            public const int Default_Health_Points = 150;
            public const Faction Default_Faction = Faction.Melee;
            public const int Default_Ability_Points = 150;
        }
        
        public static class Knight
        {
            // Public constant fields for default values (Knight)
            public const string Default_Name = "Finn the Programmer";
            public const int Default_Level = 10;
            public const int Default_Health_Points = 200;
            public const Faction Default_Faction = Faction.Melee;
            public const int Default_Ability_Points = 350;
        }
       

        // Constants for Spellcaster characters

        public static class Mage
        {
            // Public constant fields for default values (Mage)
            public const string Default_Name = "Ice King";
            public const int Default_Level = 10;
            public const int Default_Health_Points = 75;
            public const Faction Default_Faction = Faction.Spellcaster;
            public const int Default_Mana_Points = 200;
        }

        public static class Druid
        {
            // Public constant fields for default values (Druid)
            public const string Default_Name = "Magic Man";
            public const int Default_Level = 17;
            public const int Default_Health_Points = 175;
            public const Faction Default_Faction = Faction.Spellcaster;
            public const int Default_Mana_Points = 250;
        }

      public static class Necromancer
        {

            // Public constant fields for default values
            public const string Default_Name = "The Lich King";
            public const int Default_Level = 30;
            public const int Default_Health_Points = 325;
            public const Faction Default_Faction = Faction.Spellcaster;
            public const int Default_Ability_Points = 400;
        }

    }
}
