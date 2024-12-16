using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.AbsrtractClasses
{
    public abstract class IQuestItem
    {
        public abstract string GetName();

        public abstract string GetDescription();

        public abstract Image GetImage();

        public abstract Point GetLocation();

        public abstract Size GetSize();
    }
}
