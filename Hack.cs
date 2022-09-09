using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public class Hack
    {
        private
            string name = "";
            string description = "";
            int fpIn;

        // statbase
        int[] statbaseDArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] statbaseArr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int dpIn;
            int enI;
            int enAlly;
            int enEv;
            int enMgk;
        int enEx;
        int outEn;
        int enReq; // en required
        int recourses; // memory used
        int codebaseSize; // thiccness of the code = atypical size

        int energy; // required energy = energy used (injector energy required)
        int synthesis; // non-factoral to cp. factoral to energy cutting /= fpd * dp * cull

        int cull; // non-factoral to cp. factoral to energy cutting. 
                  //culling comes from power that is outside the user (allies, items, env, etc)
                  // cull = outerfpd + outerEn
        int targetRadius = 0; // 0 single, 1 multi, 2 aoe
        List<string> eff = new (); // total status afflictions
        List<string> targetNames = new(); // if single target // pop the bottom of whatever targets are in question
        private float cp;

        public Hack(string name, int fpIn, int dpIn, int enI,
            int enAlly, int enEv, int enMgk,
            int enEx, int outEn, int codebaseSize, 
            int compSpeed, int energy, int synthesis,
            int cull, int targetRadius, string descrp)
        {
            this.fpIn = fpIn;
            this.dpIn = dpIn;
            this.enI = enI;
            this.enAlly = enAlly;
            this.enEv = enEv;
            this.enMgk = enMgk;
            this.enEx = enEx;
            this.outEn = outEn;
            this.EnReq = enReq;
            this.Recourses = recourses;
            this.CodebaseSize = codebaseSize;
            this.Energy = energy;
            this.Synthesis = synthesis;
            this.Cull = cull;
            this.TargetRadius = targetRadius;
            this.Description = descrp;
        }

        void cutEn(int d, int a)
        {
            enReq -= d + a;
        }

        void setCp(int cpIn)
        {
           // cp = racks * (nodes / rack) * (sockets / node) * (core / socket) * (cycles / second) * (FLOPs / cycle);
            cp += cpIn;
        }


        void setCull(int enI, int enally, int enEnv, int enMgk, int enEx)
        {
            cull = enI * enally * enEnv * enMgk * enEx;
        }




        void setSythesis(int fp, int dp, int cull)
        {
            this.Synthesis += fp * dp * cull;
        }



        void setName(string d)
        {
            this.Name = d;
        }

        bool execute(int enReq, int enRedux, int maxEnIn, int CpUp)
        {
            enReq += this.enReq;
            enReq -= enRedux;
            this.cp += CpUp;
            if (!(enReq > maxEnIn))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        string getName()
        {
            return this.Name;
        }

        Skill stealSkill(int f, Skill[] c)
        {
            return c[f]; // just load this into the thing
        }

        Magic disableMgk(int d, Magic[] m)
        {
            m[d].setEnabled(false);
            return m[d];
        }

        Enemy removal(int w, Enemy[] d)
        {
            d[w].Name = "";
            return d[w];
        }

        string targetBuff(int g, string[] d)
        {
            return d[g];
        }

        string target(int h, string[] d)
        {
            return d[h];
        }

        string removalp(int y, string[] p)
        {
            return p[y];
        }

        void removeStat(int call, int []statb)
        {
            statb[call] = 0;
        }

        public string statusCall(string w)
        {
            int i = 0;
            for (IList it = eff.ToArray(); 
                it[i] != it[eff.IndexOf(eff.Last())]; ++i)
            {
                if (eff[it.IndexOf(w)].Equals(""))
                {
                    eff.RemoveAt(it.IndexOf(w));
                }
                if (eff[i] == w)
                {
                    return eff[i];
                }
            }
            return eff[i];
        }

        string targetStatusChange(string zName, string sdChanger)
        {
            zName = sdChanger;
            return zName;
        }

        void reName(string zName)
        {
            Name = zName;
        }

        int ChangeSide(int d, int yourSide)
        {
            int choice= 0;
            char sndChoice = '$';
            //cout << "What side do you want this target to be on..?" << endl;
            //cin >> choice; leave these here
            if (choice != yourSide)
            {
                //cout << "That's not your side? are you sure? (y) (n) " << endl;
            }
            //cin >> sndChoice; 
            switch (sndChoice)
            {
                case 'y':
                    //cout << "Change complete!" << endl;
                    //system("PAUSE");
                    return choice;

                case 'n':
                    return choice;
                //changeSide(d, yourSide);

                default:
                    //cout << "try again..." << endl;
                    //system("PAUSE");
                    break;
            }
            return choice;
        }

        int Ddoss(int serviceTurnsLost, int cp)
        {
            int max_turn_loss = cp / 2;
            int choice = 0;
            //cout << "Are you sure this counts the turns you need...? 1 -" << " " << max_turn_loss << endl;
            //cout << "Select the turns you want your enemy to lose.." << endl;
            //cin >> choice;
            if (choice > max_turn_loss)
            {
                //cout << "Critical failure....." << endl;
                //system("PAUSE");
                return 0;
            }
            return choice;
        }

        void ReProgram()
        {
            //string doAction = "";
            //cout << "What do you want done?" << endl;
            //cin >> doAction;
        }

        string StatusChange(string w, string change) // void?
        {
            int i = 0;
            for (IList it = eff.ToArray();
                it[i] != it[eff.IndexOf(eff.Last())]; ++i)
            {
                if (it.Count == 0)
                {
                    eff.RemoveAt(it.IndexOf(w));
                }
                if (eff[i] == w)
                {
                    eff.RemoveAt(it.IndexOf(w));
                    eff.Add(change);
                    return eff[i];
                }
            }
            return ""; // change?
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int FpIn { get => fpIn; set => fpIn = value; }
        public int DpIn { get => dpIn; set => dpIn = value; }
        public int EnI { get => enI; set => enI = value; }
        public int EnAlly { get => enAlly; set => enAlly = value; }
        public int EnEv { get => enEv; set => enEv = value; }
        public int EnMgk { get => enMgk; set => enMgk = value; }
        public int EnEx { get => enEx; set => enEx = value; }
        public int OutEn { get => outEn; set => outEn = value; }
        
        public int EnReq { get => enReq; set => enReq = value; }
        public int Recourses { get => recourses; set => recourses = value; }
        public int CodebaseSize { get => codebaseSize; set => codebaseSize = value; }
        public int Energy { get => energy; set => energy = value; }
        public int Synthesis { get => synthesis; set => synthesis = value; }
        public int Cull { get => cull; set => cull = value; }
        public int TargetRadius { get => targetRadius; set => targetRadius = value; }
        //public List<string> Eff1 { get => eff; set => eff = value; }
        public List<string> TargetNames1 { get => targetNames; set => targetNames = value; }
    }
}
