using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    public class Weapon : Item
    {
        public int MaximumDamage { get; set; }
        public int MinumumDamage { get; set; }

        public Weapon(int id, string name, string nameplural, int maxdmg, int mindmg) : base(id, name, nameplural)
        {
            MaximumDamage = maxdmg;
            MinumumDamage = mindmg;
        }
    }
}
