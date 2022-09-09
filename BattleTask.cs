using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Basics_Lib
{
    public class BattleTask
    {
		enum TaskType
        {
			Attack, // weapon + armor and base stat damage combo /
			Defend, // damage reduction /
			Act, // interface with enemies, allies, area and events /
			Hack, // Discombobulate the inner workings of your victim /
			Skill, // Skills = armor + weapon + base stat damage + effects + critmultiplier /
			ST, // Special Techniques /
			Summon, // deploy robots, call pets, summon Geists or Beckon Vulcanite /
			Magic, // cast some magical shit /
			Items, // consumables and mcguffins /
			Customize, // change gear /
			Escape // Chance roll. Run from the fight /
		}
		private int db_choice = 0; // picks the skill, action, ST..etc in its array
		int targetRange = 0; // 0 = single, 1 = multi, 2 = AOE
		TaskType decision = TaskType.Attack;// What are you doing? Attacking? Defending?
		char Tc = 'k'; // letter = Tasktype abbreviated for the ActionBase
		Array allyR = new Array[6]; // Ally Target(s) <- leave this alone in mind
		Array enemyR = new Array[6]; // Enemy target(s) <- leave this alone /
		Battler? singleTarget;
		Array multiTarget = new Array[10]; //(Battler) 
		Battler? selfTarget;
		int isTask = 1; // 1 for yes 0 for no //default is 1
		/// <summary>
		/// team 1 + is good 
		/// team 0 is bad
		/// anything else is another faction or enemy
		///</summary>
		/// <param name="team_num"></param>
		/// <returns></returns>
		int team_num = 0;
		string message = "";
	}
}
