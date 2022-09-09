using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public partial class Actor
    {
        private
        const int statusGroups = 20;
        bool leader;
        bool isPlayer = false;
        int EXP = 0;
        int max_party_num = 6;
        int num_Statuses = 0;
        int turn_Num = 0; // this defines the order in the turn hierarchy later on
        string title = "";

        //string My_Statuses;
        string name = "";
        string bio = "";
        bool statmulti = false;
        int dummy = 0;
        int newSpd = 0; // for the battle system only
        ElementType d;

        public bool Leader { get => leader; set => leader = value; }
        public bool IsPlayer { get => isPlayer; set => isPlayer = value; }
        public int EXP1 { get => EXP; set => EXP = value; }
        public int Max_party_num { get => max_party_num; set => max_party_num = value; }
        public int Num_Statuses { get => num_Statuses; set => num_Statuses = value; }
        public int Turn_Num { get => turn_Num; set => turn_Num = value; }
        public string Title { get => title; set => title = value; }
        public Array? StatbaseArr1 { get; set; } = new Array[14];
        public Array? StatbasedArr1 { get; set; } = new Array[14];
        public string Name { get => name; set => name = value; }
        public string Bio { get => bio; set => bio = value; }
        public bool Statmulti { get => statmulti; set => statmulti = value; }
        public int Dummy { get => dummy; set => dummy = value; }
        public int NewSpd { get => newSpd; set => newSpd = value; }
        public ElementType D { get => d; set => d = value; }

        public

        Actor()
        {
            name = "nullDummy";
            title = "";
            this.IsPlayer = false;
            this.Leader = false;
            this.bio = "";
        }
        public Actor(string name, string bio,
            bool leader, bool isPlayer,
            int EXP, int maxpn,
            int num_statuses, int turnN,
            string title, ElementType el,
            Array array, Array arrayd)
        {
            this.Name = name;
            this.Bio = bio;
            this.Leader = leader;
            this.IsPlayer = isPlayer;
            this.EXP1 = EXP;
            Max_party_num = maxpn;
            Num_Statuses = num_statuses;
            Turn_Num = turnN;
            this.Title = title;
            D = el;
            StatbaseArr1 = array;
            StatbasedArr1 = arrayd;
        }
        public enum ElementType // enums are always private TYPED
        {
            Water = 0,
            Fire = 1,
            Earth = 2,
            Air = 3,
            Lightning = 4,
            Phase = 5,
            Bio = 6,
            Light = 7,
            Dark = 8,
            Normal = 9
        }
        ElementType GetElement()
        { return D; }


        #region gets
        bool GetLeadRole()
        {
            return Leader;
        }

        public void SetName(string n) => this.Name = n;
        string GetName()
        {
            return Name;
        }

        string GetTitle()
        {
            return Title;
        }

        int GetNumOfStates()
        {
            return Num_Statuses;
        }

        int GetParty_num()
        {
            return Max_party_num;
        }

        bool GetSMulti()
        {
            return Statmulti;
        }
        #endregion

        #region sets
        void SetElement(int e)
        { D = (ElementType)e; }
        void SetStatBaseCall(int call, int set)
        {
            // 15 stb
            StatbaseArr1.SetValue(call, set);
        }
        // todo Status eff
        void remStatus(int rem)
        {
            // calc this one later
        }
        // todo
        void getStatus(int c)
        {

        }
        // todo
        void printState()
        {

        }

        // ??
        string normalOutput(string normal)
        {
            return normal;
        }

        //
        string getActorName()
        {
            return Name;
        }

        void SetStatBar(int c, int s)
        {
            StatbasedArr1.SetValue(c, s);
        }
        void InitEveryBV(int[] inits) // stb 15
        {
            StatbaseArr1.SetValue(0, inits[0]);
            StatbaseArr1.SetValue(1, inits[1]);
            StatbaseArr1.SetValue(2, inits[2]);
            StatbaseArr1.SetValue(3, inits[3]);
            StatbaseArr1.SetValue(4, inits[4]);
            StatbaseArr1.SetValue(5, inits[5]);
            StatbaseArr1.SetValue(6, inits[6]);
            StatbaseArr1.SetValue(7, inits[7]);
            StatbaseArr1.SetValue(8, inits[8]);
            StatbaseArr1.SetValue(9, inits[9]);
            StatbaseArr1.SetValue(10, inits[10]);
            StatbaseArr1.SetValue(11, inits[11]);
            StatbaseArr1.SetValue(12, inits[12]);
            StatbaseArr1.SetValue(13, inits[13]);
            StatbaseArr1.SetValue(14, inits[14]);
        }

        void InitEveryBar(int[] inits)
        {
            StatbasedArr1.SetValue(0, inits[0]);
            StatbasedArr1.SetValue(1, inits[1]);
            StatbasedArr1.SetValue(2, inits[2]);
            StatbasedArr1.SetValue(3, inits[3]);
            StatbasedArr1.SetValue(4, inits[4]);
            StatbasedArr1.SetValue(5, inits[5]);
            StatbasedArr1.SetValue(6, inits[6]);
            StatbasedArr1.SetValue(7, inits[7]);
            StatbasedArr1.SetValue(8, inits[8]);
            StatbasedArr1.SetValue(9, inits[9]);
            StatbasedArr1.SetValue(10, inits[10]);
            StatbasedArr1.SetValue(11, inits[11]);
            StatbasedArr1.SetValue(12, inits[12]);
            StatbasedArr1.SetValue(13, inits[13]);
        } // main gets bars n such


        #endregion

        ~Actor()
        {
            // todo
            //if(this.isPlayer && gametype = 0)
            //{
            // call game over for this player
            // }
        }
    }
}
