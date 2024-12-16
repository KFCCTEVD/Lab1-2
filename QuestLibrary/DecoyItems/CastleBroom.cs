using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.DecoyItems
{
	public class CastleBroom : IDecoyItem
	{
		static Image image;

		public override string GetName()
		{
			return "Castle Broom";
		}

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/decoy_items/CastleBroom.png");

			return image;
		}

		public override Point GetLocation()
		{
			return new Point(625, 345);
		}

		public override Size GetSize()
		{
			return new Size(50, 50);
		}
	}
}
