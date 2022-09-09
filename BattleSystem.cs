using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    /// <summary>
    /// todo : FINISHING THIS CLASS
    /// </summary>
    public class BattleSystem
    {
        private 
            // todo learn this 
            //ConcurrentExclusiveSchedulerPair SchedulerPair { get ; set; }
        Queue<BattleTask> TaskBase = new Queue<BattleTask>();
        
        List<PartyActor> partyActors = new List<PartyActor>(); // WP
        List<PartyActor> partyActorsCpy = new List<PartyActor>(); // wpc
        List<PartyActor> partyF = new List<PartyActor>(); // final

        // baddies
        List<AllySummon> Pets = new List<AllySummon>();
        List<Enemy> troop = new List<Enemy>();
        List<AllySummon> EnemySummons = new List<AllySummon>();
        List<Enemy> ?troopF;
        List<Enemy> ?troopcpy;
        bool ag0 = false;
        bool aGuage = false;
        bool battleTime = false;
        Inventory playerInvent = new Inventory();
        Inventory spoils = new Inventory(10);

        // battler Array

        Array AllBattlers = new Array[14];
        Array AllBattlersF = new Array[14];
        List<int> SpdArr = new List<int>();
        List<int> SpdArrD = new List<int>();
        List<int> AllSpdArr = new List<int>(); // gud and bad
        List<Battler> AllBattlersList = new List<Battler>();

            
        public
        BattleSystem()
        {
            ag0 = false; // This checks for whether or not its your starting turn
            aGuage = ag0;
            battleTime = true;
        }
        public BattleSystem(PartyActor[] crew,
            Enemy[] badies,
            bool ag, bool battle)
        {
            spoils = new Inventory(10);
            troopF = new List<Enemy>();
            Pets = new List<AllySummon>();
            troopcpy = new List<Enemy>();
            AllBattlers = crew;
            AllBattlersF = badies;
            ag0 = ag; // This checks for whether or not its your starting turn
            aGuage = ag0;
            battleTime = battle;
            
        }

        void phaseTrigger(phase j)
        {
            // initials being set

            phase turn = j;
            // look into the turn list

            for (int i = 0; i < 2; i++)
            {
                // 6 turn branch 
                switch (turn)
                {
                    case phase.cl: // turn A mode Clash time
                        //++turn_Number;
                        //clashMode();
                        break;

                    case phase.T1P:
                        //++turn_Number;
                        //turnCallPVP();
                        break;

                    case phase.TC:
                        //TurnCheck();
                        break;

                    case phase.ET:
                        ///++turn_Number;
                        //aiTurn();
                        break;

                    case phase.TCII:
                        //TurnCheckII();
                        //ReOrderSettto();
                        break;

                    case phase.DCU:
                        //damage calculation
                        //UpdateALL();
                        //hpCheck();
                        //ReOrderSettto();
                        //TurnCheck();
                        break;

                    case phase.MUL:
                        //++turn_Number;
                        //multiTurnCall();
                        break;

                    case phase.END:
                        //BattleMode::~BattleMode();
                        i = 2;
                        break;

                    default:
                        
                        //UpdateALL();
                        //hpCheck();
                        //ReOrderSettto();
                        //TurnCheck();
                        break;
                }
            }
        }

        enum phase
        {
            cl = 0, // clash
            T1P = 1, // turn 1 player
            TC = 2, // turn check
            ET = 3, // enemy turn
            TCII = 4, // turn check
            DCU = 5,  // DC update reset/determine turn
            MUL = 6, // multiturn
            END = 7 // call rewards and end the battle
       
        }

        /* todo
        public static phase operator ++(int n)
        {
            n += 1;
            switch (n)
            {
                case 0: return phase.T1P;
                case 1: return phase.TC;
                case 2: return phase.ET;
                case 3: return phase.TCII;
                case 4: return phase.DCU;
                case 5: return phase.MUL;
                case 6: return phase.END;
                case 7: return phase.cl;
            }
            n = 0;
            return phase.TC;
        }
        */

    }
}
