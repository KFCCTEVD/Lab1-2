using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.QuestItems
{	
	public class RoyalCrown : IQuestItem
	{
		static Image image;

		public override string GetName()
		{
			return "Royal Crown";
		}

		public override string GetDescription()
		{
			return "The Royal Crown of the Fallen King.";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/quest_items/RoyalCrown.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(586, 179);
		}

		public override Size GetSize()
		{
			return new Size(30, 30);
		}
	}
}
