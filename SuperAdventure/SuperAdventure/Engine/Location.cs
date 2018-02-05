using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAdventure.Engine
{
    class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSout { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name, string desc, Item itemreqtoenter = null, Quest questavailhere = null, Monster monsterlivinghere = null)
        {
            ID = id;
            Name = name;
            Description = desc;
            ItemRequiredToEnter = itemreqtoenter;
            QuestAvailableHere = questavailhere;
            MonsterLivingHere = monsterlivinghere;
        }
    }
}
