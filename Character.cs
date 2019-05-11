using System;



namespace Characters
{
    public class Character
        {
        public enum  gender { MALE,FEMALE};
        public enum classType {Barbarian,Fighter,Knight,Paladin,Cleric,Priest,Rogue,Magician,Ranger,Other}; //I.E A generic name for a specific class type. Death Knight - Dark knight, Arcane Trickster - rogue, Sunlight Paladin - Paladin
        public enum race { Human,Elf,Dwarf,Gnome,NonHuman}
        private string CharacterName; //Character name;
        private string classname; //Player given class name
        private int ClassType;


        //private Inventory inventory;
        //private StatSheet stats;
        



        


        public string CharacterDescription; //Short or really long character description



        }

}

