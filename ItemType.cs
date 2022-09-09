namespace RPG_Basics_Lib
{
    public partial class ItemClass
    {
        [Serializable]
        private enum ItemType
        {
            Item = 0,
            Weapon = 1,
            Armor = 2,
            Acc = 3,
            Custom = 4, // add as many as these types as desired
        };

        public ItemClass(int item, string name, int hp, int sp, 
            int fp, int atk, int def, int speed,
            int agi, int dex, int intel, int spr,
            int str, int end, int con, 
            int value, int quantity, int[] stb): 
            this(item, name, hp, sp, fp, atk, def
                  , speed, agi, dex, intel,
                  spr, str, end, con, value, quantity)
        {
            iType = ItemType.Weapon;
            this.stb = stb;
            Stb = stb;
            Name = name;
            
        }  
    }
}
