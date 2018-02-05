using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    class LivingCreature
    {
        public int CurrentHitpoints { get; set; }
        public int MaximumHitpoints { get; set; }

        public LivingCreature(int currenthp, int maxhp)
        {
            CurrentHitpoints = currenthp;
            MaximumHitpoints = maxhp;
        }
    }
}
