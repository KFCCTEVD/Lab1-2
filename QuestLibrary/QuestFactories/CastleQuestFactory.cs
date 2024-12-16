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
	public class CastleQuestFactory : IQuestFactory
	{
		public override List<IDecoyItem> CreateDecoyItems()
		{
			return new List<IDecoyItem>()
			{
				new CastleBroach(), 
				new CastleBroom(), 
				new CastleLance()
			};
		}

		public override IQuest CreateQuest()
		{
			return new CastleQuest();
		}

		public override IQuestItem CreateQuestItem()
		{
			return new RoyalCrown();
		}

		public override IQuestRoom CreateQuestRoom()
		{
			return new CastleQuestRoom();
		}
	}
}
