using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.DecoyItems
{
	public class VillageHammer : IDecoyItem
	{
		static Image image;

		public override string GetName()
		{
			return "Village Hammer";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/decoy_items/VillageHammer.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(393, 456);
		}

		public override Size GetSize()
		{
			return new Size(50, 50);
		}
	}
}
