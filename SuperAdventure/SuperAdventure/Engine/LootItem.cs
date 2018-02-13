using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int droppercent, bool isdefaultitem)
        {
            Details = details;
            DropPercentage = droppercent;
            IsDefaultItem = isdefaultitem;
        }
    }
}
