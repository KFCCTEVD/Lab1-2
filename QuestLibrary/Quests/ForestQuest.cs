using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Quests
{
	public class ForestQuest : IQuest
	{
		public override string GetName()
		{
			return "The legend of an Ancient Ammulet";
		}

		public override string GetDescription()
		{
			return "Find mystical Ancient Ammulet that was lost during a battle in the forest.";
		}
	}
}
