using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    internal class Battler
    {
		string name = "";

		// whose team the battler's on.
		int team = 0;

		// statbase
		int [] statbaseDArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		int [] statbaseArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        // strings of states
        //string[] states = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        /* armor reference
		int maxhp = 0; // 0
		int maxsp = 0; // 1
		int fp = 0; // 2
		int ap = 0;// 3
		int atk = 0; //4
		int def = 0; //5
		int speed = 0; //6
		int agi = 0; // 7
		int dex = 0; // 8
		int intel = 0; // 9
		int spr = 0; // 10
		int str = 0; // 11
		int end = 0; //12
		int con = 0; //13
		int value = 0; //14
		int quantity = 0; //15
		*/
        // Weapons (16 stats including gold value)

		// Armors (16 stats including gold value)

	// keep these objects below strings:
	// 
	// Skills
	string[] skillBase = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
	// STs
	string[] Stbase={ "","","", "", "", "", "", "", "", "", "", "", "", "", "","","", "", "", "" };
// Actions
string []ActonBase={ "","","", "", "", "", "", "", "", "", "", "", "", "", "","","", "", "", "" };
// Hacks
string []CodeBase={ "","","", "", "", "", "", "", "", "", "", "", "", "", "","","", "", "", "" };
// Summons
string []SummonBase = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
// Magic
string []MagicBase = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

// statBase reference
/* battler stats
{
hp, 0
sp, 1
fp, 2
ATK, 3
DEF, 4
SPEED, 5
AGI, 6
DEX, 7
INT, 8
SPR, 9
STR, 10
END, 11
CON 12
GOLD 13
};
*/
// 1 - 3 weak 50%, moderate 67%, strong 72%
// 1 = .5
// 2 = .67
// 3 = .72
float defFlag;
float actionFlag;
float magicFlag;
float escapeFlag;
float stFlag;
float skillFlag;
float attackFlag;
float summonFlag;
float hackFlag;
        public Battler()
        {
            
        }
        public Battler
            (
                string name,
                int team,
                int[] statbaseDArr,
                int[] statbaseArr,
                //string[] states,
                string[] skillBase,
                string[] stbase,
                string[] actonBase,
                string[] codeBase,
                string[] summonBase,
                string[] magicBase,
                float defFlag,
                float actionFlag,
                float magicFlag,
                float escapeFlag,
                float stFlag,
                float skillFlag,
                float attackFlag,
                float summonFlag,
                float hackFlag
            )
        {
            Name = name;
            Team = team;
            StatbaseDArr = statbaseDArr;
            StatbaseArr = statbaseArr;
            //States = states;
            SkillBase = skillBase;
            Stbase = stbase;
            ActonBase = actonBase;
            CodeBase = codeBase;
            SummonBase = summonBase;
            MagicBase = magicBase;
            DefFlag = defFlag;
            ActionFlag = actionFlag;
            MagicFlag = magicFlag;
            EscapeFlag = escapeFlag;
            StFlag = stFlag;
            SkillFlag = skillFlag;
            AttackFlag = attackFlag;
            SummonFlag = summonFlag;
            HackFlag = hackFlag;
        }


        public float DefFlag 
        { get => defFlag; set => defFlag = value; }
        public float ActionFlag 
        { get => actionFlag; set => actionFlag = value; }
        public float MagicFlag 
        { get => magicFlag; set => magicFlag = value; }
        public float EscapeFlag 
        { get => escapeFlag; set => escapeFlag = value; }
        public float StFlag 
        { get => stFlag; set => stFlag = value; }
        public float SkillFlag 
        { get => skillFlag; set => skillFlag = value; }
        public float AttackFlag 
        { get => attackFlag; set => attackFlag = value; }
        public float SummonFlag
        { get => summonFlag; set => summonFlag = value; }
        public float HackFlag
        { get => hackFlag; set => hackFlag = value; }
        public string Name 
        { get => name; set => name = value; }
        public int Team
        { get => team; set => team = value; }
        public int[] StatbaseDArr 
        { get => statbaseDArr; set => statbaseDArr = value; }
        public int[] StatbaseArr 
        { get => statbaseArr; set => statbaseArr = value; }
        //public string[] States 
        //{ get => states; set => states = value; }
        public string[] SkillBase 
        { get => skillBase; set => skillBase = value; }
        public string[] Stbase1 
        { get => Stbase; set => Stbase = value; }
        public string[] ActonBase1
        { get => ActonBase; set => ActonBase = value; }
        public string[] CodeBase1 
        { get => CodeBase; set => CodeBase = value; }
        public string[] SummonBase1 
        { get => SummonBase; set => SummonBase = value; }
        public string[] MagicBase1
        { get => MagicBase; set => MagicBase = value; }
    }
}
