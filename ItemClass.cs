using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public partial class ItemClass
    {

		string name = "";
        ItemType iType;
        
		int hp = 0;
		int sp = 0;
		int fp = 0;
		int atk = 0;
		int def = 0;
		int speed = 0;
		int agi = 0;
		int dex = 0;
		int intel = 0;
		int spr = 0;
		int str = 0;
		int end = 0;
		int con = 0;
		int value = 0;
        int quantity = 0;

        int[] stb = new int[14];

        public ItemClass(int item, string name, int hp, int sp,
            int fp, int atk, int def, 
            int speed, int agi, int dex, 
            int intel, int spr, int str,
            int end, int con, int value, int quantity)
        {
            this.Name = name;
            this.hp = hp; // 0 
            this.sp = sp;
            this.fp = fp;
            this.atk = atk;
            this.def = def;
            this.speed = speed;
            this.agi = agi;
            this.dex = dex;
            this.intel = intel;
            this.spr = spr;
            this.str = str;
            this.end = end;
            this.con = con;
            this.value = value;
            this.quantity = quantity; // 14
            iType = (ItemType)item;

            Stb[0] = hp;
            Stb[1] = sp;
            Stb[2] = fp;
            Stb[3] = atk;
            Stb[4] = def;
            Stb[5] = speed;
            Stb[6] = agi;
            Stb[7] = dex;
            Stb[8] = intel;
            Stb[9] = spr;
            Stb[10] = str;
            Stb[11] = end;
            Stb[12] = con;
            Stb[13] = value;
            Stb[14] = quantity;


        }

        ItemClass()
		{
            Name = "";
            iType = ItemType.Custom;

            Stb[0] = hp;
            Stb[1] = sp;
            Stb[2] = fp;
            Stb[3] = atk;
            Stb[4] = def;
            Stb[5] = speed;
            Stb[6] = agi;
            Stb[7] = dex;
            Stb[8] = intel;
            Stb[9] = spr;
            Stb[10] = str;
            Stb[11] = end;
            Stb[12] = con;
            Stb[13] = value;
            Stb[14] = quantity;
        }

        public int[] Stb { get => stb; set => stb = value; }
        public string Name { get => name; set => name = value; }

        static int GetStatP(int[] inD, int sel) => inD[sel];
    }
}
