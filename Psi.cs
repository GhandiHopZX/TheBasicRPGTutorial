using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
	/// <summary>
	/// 
	/// </summary>
	public class Psi
	{

		private
		string name = "";
		int penNeg = 0; // temp go down
		int penPos = 0; // temp go up

		public
		//ctr
		Psi()
		{

		}
		//name , positive limit, negative limit
		Psi(string name, int pos, int neg)
		{
			this.name = name;
			penPos = pos;
			penNeg = neg;
		}
		//Trigger Effect and Status Call
		Psi(string name, int pos, int neg, string Eff, string Status)
        {
			this.name = name;
			this.penPos = pos;
			
        }
		//setters
		int GetNeg()
        {
			return penNeg;
        }
		int GetPos()
        {
			return penPos;
        }
		string GetName()
        {
			return name;
        }

		//accors
		void SetNeg(int r)
			=> penNeg = r;
		void SetPos(int t)
		{
			penPos = t;
		}
		void SetName(string e)
        {
			name = e;
        }

		// battle functions 

		// psiplus, psineg, temperment
		// this thing deals damage or gives
		// life. Whatever you want.
		// higher or lower,
		// if its a Psiability that 
		// has negative limits eg -12
		// and the final modifier is -11
		// then the ability is going to do
		// damage.
		// Likewise a positive 
		// modifier does the opposite
		int PsiCalc(int pos, int neg, int temper)
        {
			int mod = 0;
			temper -= neg;
			temper += pos;

			if (temper <= neg || temper >= pos)
			{
				mod = 0;
			}

			if (temper == neg + 1 || temper == pos - 1) // danger zone
			{
				mod %= temper * pos + neg; // critemperical mass
			}

			if (temper > neg && temper < pos && temper == (pos + neg) / 2) // perfect zen
			{
				mod += temper * pos; // fck yea
				mod -= temper * neg;
			}

			if (temper > neg && temper < pos)
			{
				mod = temper;
			}

			return mod;
		}
		// turns of effect
		int TurnsOE(int pCalc, int neg, int pos)
        {
			pCalc %= pos * pCalc * neg;
			return pCalc;
		}
	}
}

