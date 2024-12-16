using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Quests
{
	public class VillageQuest : IQuest
	{
		public override string GetName()
		{
			return "The Lost Book of Martial Arts";
		}

		public override string GetDescription()
		{
			return "A villager has asked you to find his father's lost book.";
		}
	}
}
