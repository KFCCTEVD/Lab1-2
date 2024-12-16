using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.AbsrtractClasses
{
    public abstract class IQuest
    {
        public abstract string GetName();

        public abstract string GetDescription();
    }
}
