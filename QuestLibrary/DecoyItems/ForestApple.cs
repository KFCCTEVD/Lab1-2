using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.DecoyItems
{
	public class ForestApple : IDecoyItem
	{
		static Image image;

		public override string GetName()
		{
			return "Forest Apple";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/decoy_items/ForestApple.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(783, 177);
		}

		public override Size GetSize()
		{
			return new Size(50, 50);
		}
	}
}
