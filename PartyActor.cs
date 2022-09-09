using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    /// <summary>
    /// example instantiation:
    /// Array fe = new Array[14];
    /// PartyActor w = new PartyActor
    ///    ("s", "efw", (int[])fe, "", false,
    ///    Actor.ElementType.Air,
    ///    false, 10, false, 1);
    ///    use an Array type and conversion for the
    ///    statbase
    /// </summary>
    public class PartyActor : Actor
    {
        public PartyActor(string name, string bio, 
            int[] ints, string title, bool statMulti, 
            ElementType element, bool leader,
            int exp, bool isplayer,
            int mpn)
        {
            SetName(name);
            Bio = bio;
            Title = title;
            Statmulti = statMulti;
            D = element;
            Leader = leader;
            StatbasedArr1 = ints; // set to max
            StatbaseArr1 = ints;
            EXP1 = exp;
            IsPlayer = isplayer;
            Max_party_num = mpn;
            Num_Statuses = 0;
            Turn_Num = 0;
        }
    }
}
