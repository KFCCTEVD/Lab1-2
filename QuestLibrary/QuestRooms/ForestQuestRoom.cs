using QuestLibrary.AbsrtractClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.QuestRooms
{
	public class ForestQuestRoom : IQuestRoom
	{
		static Image image;

		public override Image GetImage()
		{
			if (image == null)
				image = Image.FromFile("resources/images/rooms/ForestRoom.png");

			return image;
		}
	}
}
