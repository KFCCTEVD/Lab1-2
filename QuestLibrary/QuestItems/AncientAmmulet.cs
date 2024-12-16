using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.QuestItems
{
	public class AncientAmmulet : IQuestItem
	{
		static Image image;

		public override string GetName()
		{
			return "Ancient Amulet";
		}

		public override string GetDescription()
		{
			return "Mystical Ancient Ammulet.";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/quest_items/AncientAmmulet.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(911, 280);
		}

		public override Size GetSize()
		{
			return new Size(30, 30);
		}
	}
}
