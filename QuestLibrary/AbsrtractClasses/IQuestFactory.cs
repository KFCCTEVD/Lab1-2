using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestLibrary.AbsrtractClasses
{
    public abstract class IQuestFactory
    {
        public abstract IQuestItem CreateQuestItem();

        public abstract List<IDecoyItem> CreateDecoyItems();

        public abstract IQuestRoom CreateQuestRoom();

        public abstract IQuest CreateQuest();
    }
}
