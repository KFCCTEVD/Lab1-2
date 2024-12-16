using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.Quests
{
	public class CastleQuest : IQuest
	{
		public override string GetName()
		{
			return "Return Royal Crown of the Fallen King";
		}

		public override string GetDescription()
		{
			return "Inspect whole castle to find Royal Crown of the Fallen King.";
		}
	}
}
