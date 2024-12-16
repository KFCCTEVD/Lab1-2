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
	public class VillageQuestFactory : IQuestFactory
	{
		public override List<IDecoyItem> CreateDecoyItems()
		{
			return new List<IDecoyItem>()
			{
				new VillageAxe(), 
				new VillageBoots(), 
				new VillageHammer()
			};
		}

		public override IQuest CreateQuest()
		{
			return new VillageQuest();
		}

		public override IQuestItem CreateQuestItem()
		{
			return new LostBook();
		}

		public override IQuestRoom CreateQuestRoom()
		{
			return new VillageQuestRoom();
		}
	}
}
