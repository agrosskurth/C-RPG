using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string nameplural, int amttoheal) : base(id, name, nameplural)
        {
            AmountToHeal = amttoheal;
        }
    }
}
