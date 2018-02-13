using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string desc, int rewxp, int rewgold)
        {
            ID = id;
            Name = name;
            Description = desc;
            RewardExperience = rewxp;
            RewardGold = rewgold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
