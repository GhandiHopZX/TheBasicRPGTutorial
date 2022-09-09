using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public class AllySummon : Actor
    {
        private
        ElementType elementType;
        string []sk;
        string[] st;
        string []mgk;
        string[] hck;
        string[] psis;
        string name;

        public 
        AllySummon(ElementType e,
            string[] exSkills,
            string[] exSTs,
            string[] exMagic,
            string[] exHack,
            string[] exPsichs,
            string name,
            Array array,
            Array arrayd)
        {
            elementType = e;
            this.sk = exSkills;
            this.st = exSTs;
            this.mgk = exMagic;
            psis = exPsichs;
            this.hck = exHack;
            this.name = name;
            StatbaseArr1 = array;
            StatbasedArr1 = arrayd;
        }
        string []exSkills
        {
            get { return sk; }
            set { sk = value; }
        }
        string []exSTs
        {
            get { return st; }
            set
            {
                st = value;
            }
        }
        string[]exMagic
        {
            get { return exMagic; }
            set { mgk = value; }
        }
        string[]exPsichs
        {
            get
            {
                return exPsichs;
            }
            set
            {
                psis = value;
            }
        }
        string[]exHacks
        {
            get
            {
                return exHacks;
            }
            set
            {
                hck = value;
            }
        }

        ElementType El
        {
            get
            {
                return elementType;
            }
            set
            {
                elementType = value;
            }
        }

    }
}
