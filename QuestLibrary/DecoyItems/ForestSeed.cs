using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.DecoyItems
{
	public class ForestSeed : IDecoyItem
	{
		static Image image;

		public override string GetName()
		{
			return "Forest Seed";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/decoy_items/ForestSeed.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(543, 275);
		}

		public override Size GetSize()
		{
			return new Size(30, 30);
		}
	}
}
