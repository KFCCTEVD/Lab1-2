using QuestLibrary.AbsrtractClasses;
using QuestLibrary.DecoyItems;
using QuestLibrary.QuestItems;
using QuestLibrary.QuestRooms;
using QuestLibrary.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.QuestFactories
{
	public class ForestQuestFactory : IQuestFactory
	{
		public override List<IDecoyItem> CreateDecoyItems()
		{
			return new List<IDecoyItem>()
			{
				new ForestApple(), 
				new ForestLeaves(), 
				new ForestSeed()
			};
		}

		public override IQuest CreateQuest()
		{
			return new ForestQuest();
		}

		public override IQuestItem CreateQuestItem()
		{
			return new AncientAmmulet();
		}

		public override IQuestRoom CreateQuestRoom()
		{
			return new ForestQuestRoom();
		}
	}
}
