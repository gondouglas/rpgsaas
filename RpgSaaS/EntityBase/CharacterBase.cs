using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBase
{
    class CharacterBase
    {

        public int maxHp { get; set; }
        public int maxMp { get; set; }
        public float currentHp { get; set; }
        public float currentMp { get; set; }
        public int Level { get; set; }
        public int currentExp { get; set; }
        public int nextLevelExp { get; set; }
        public float difficultFactor { get; set; }
        public Attributes attributes { get; set; }
        public ArrayList<Item> equipedItems { get; set; }
        public Inventory inventory { get; set; }
        public Race race { get; set; }

    }
}
