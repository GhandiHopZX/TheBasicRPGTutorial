using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public class Enemy : Actor
    {
        private
            ElementType el;
            int expA = 0;
            int itemN = 0;
            int goldA = 0;
            int partyNum = 6;
        string desc = "";
        
        public string Description { get => desc;
            set => desc = value; }
        public int ExpA { get => expA;
            set => expA = value;
        }
        public ElementType El
        {
            get => el;
            set => el = value;
        }
        public int ItemN { get => itemN; set => itemN = value; }
        //public bool Leader { get => leader; set => leader = value; }
        public int GoldA { get => goldA; set => goldA = value; }
        public int PartyNum { get => partyNum; set => partyNum = value; }
        
        public
            Enemy(string name, string 
            des, ElementType el, 
            int expA, int gA, int itemCall,
            Array array, Array arrayd)
        {
            Name = name;
            El = el;
            ExpA = expA;
            goldA = gA;
            Description = des;
            ItemN = itemCall;
            StatbaseArr1 = array;
            StatbasedArr1 = arrayd;
        }
    }
}
