using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.AbsrtractClasses
{
    public abstract class IDecoyItem
    {
        public abstract string GetName();

        public abstract Image GetImage();

		public abstract Point GetLocation();

        public abstract Size GetSize();
	}
}
