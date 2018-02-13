using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int maxdmg, int rewxp, int rewgold, int currenthp, int maxhp) : base(currenthp, maxhp)
        {
            ID = id;
            Name = name;
            MaximumDamage = maxdmg;
            RewardExperiencePoints = rewxp;
            RewardGold = rewgold;
            LootTable = new List<LootItem>();
        }
    }
}
