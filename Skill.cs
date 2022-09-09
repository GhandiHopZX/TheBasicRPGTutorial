using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public class Skill
    {
        private
            int totalDmg;
            int spR;
            int apR;
            int dmg;
            string name;
            List<string> eff = new List<string>(); // total status afflictions
            List<string> targetNames = new List<string>(); // if single target // pop the bottom of whatever targets are in question

        public int TotalDmg { get => totalDmg; set => totalDmg = value; }
        public int SpR { get => spR; set => spR = value; }
        public int ApR { get => apR; set => apR = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public string Name { get => name; set => name = value; }
        public List<string> Eff { get => eff; set => eff = value; }
        public List<string> TargetNames { get => targetNames; set => targetNames = value; }

        public
            double StatMulti
            (
                int AGI,
                int DEX,
                int INT,
                int SPR,
                int STR,
                int END,
                int CON
            )
        {
            return AGI + DEX + INT + SPR + STR + END + CON * 0.667;
        }
        public Skill(int totalDmg, int spR, 
            int apR, int dmg, 
            string name)
        {
            this.TotalDmg = totalDmg;
            this.SpR = spR;
            this.ApR = apR;
            this.Dmg = dmg;
            this.Name = name;
        }

        Skill(string n, int apr, int dmgi, int spr, int totalD, int addMul,
    int AGI, int DEX, int INT, int SPR, int STR, int END, int CON)
{
	this.Name = n;
	this.ApR = apr;
	Dmg = dmgi;
	SpR = spr;
	// statmulti
	TotalDmg = totalD;
}

    Skill(string n, int apr, int dmgi, int spr, int totalD)
    {

    Name = n;
	ApR = apr;
	Dmg = dmgi;
	SpR = spr;
	TotalDmg = totalD;
    }

    void setDmg(int d, int spIn, int apIn)
    {
        TotalDmg += d + spIn + apIn;
    }

    void setSpR(int set)
    {
        SpR = set;
    }

    void setApR(int set)
    {
        ApR = set;
    }

    void setName(string n)
    {
        Name = n;
    }

    string getName()
    {
        return Name;
    }

    int getDmg()
    {
        return TotalDmg;
    }

    int getSpR()
    {
        return SpR;
    }

    int SetApR()
    {
        return ApR;
    }

    ~Skill()
    {
    }
}
}
