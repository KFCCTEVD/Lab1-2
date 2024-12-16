using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.QuestItems
{
	public class LostBook : IQuestItem
	{
		static Image image;

		public override string GetName()
		{
			return "Lost Book of Martial Arts";
		}

		public override string GetDescription()
		{
			return "Book of Martial Arts that has been passed down through generations.";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/quest_items/LostBook.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(438, 158);
		}

		public override Size GetSize()
		{
			return new Size(50, 50);
		}
	}
}
