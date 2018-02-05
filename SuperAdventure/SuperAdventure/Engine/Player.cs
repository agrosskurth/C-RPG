using SuperAdventure.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure
{
    class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory {get; set;}
        public List<PlayerQuest> Quests { get; set; }

        public Player(int currenthp, int maxhp, int gold, int exp, int level) : base(currenthp, maxhp)
        {
            Gold = gold;
            ExperiencePoints = exp;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
