using System;

namespace RPG_Basics_Lib
{
    public class Action
    {
        private
        bool done = false;
        int times = 0;
        string idea = "";
        int priority = 0;
        string description = "";
        //string effCall; // status effects
        int targetRadius; // 0 single , 1 multi, 2 aoe
        string name = "";

        private enum FlagC
        {
			doing,
			done,  // anything other than this is not a complete action
			oldTask,
			forgetting,
        }

		public
		Action()
		{ }
		Action(bool done, int times, string idea,
			int priority, string des,
			string effCall, int targetRadius)
		{
            this.done = done;
			this.times = times;
			this.idea = idea;
			this.priority = priority;
			this.description = des;
			//this.effList.push_front(effCall);
			this.targetRadius = targetRadius;
		}
		~Action()
		{ }

		int getTimes() { return times; }
		string getIdea() { return idea; }
		int getPriority() { return priority; }
		bool getFlag() { return done; }
		string getDes() { return description; }
		//string getEff() { return effCall; }
		int getTargetR() { return targetRadius; }

		//void popFrontEffList() { effList }
		void setFlag(FlagC d) 
		{  
			switch(d)
            {
				case FlagC.doing:
					done = false;
					break;
				case FlagC.forgetting:
					done = false;
					break;
				case FlagC.oldTask:
					done = false;
					break;
				case FlagC.done:
					done = true;
					break;
            }
		}
		void setTimes(int e) 
		{ 
			times = e;
		}
		void setIdea(string n) 
		{
			idea = n;
		}
		void setPriority(int e) { priority = e; }
		void setDes(string d) { description = d; }
		//void setEff(string ef) { }
		void setTargetR(int r) { targetRadius = r; }

		//Queue<string> effList = new Queue<string>();
	}

}