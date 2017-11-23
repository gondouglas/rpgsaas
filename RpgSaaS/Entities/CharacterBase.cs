using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CharacterBase : EntityBase
    {
        public string name { get; set; }
        public int maxHp { get; set; }
        public int maxMp { get; set; }
        public int maxSp { get; set; }
        public float currentHp { get; set; }
        public float currentMp { get; set; }
        public float currentSp { get; set; }
        public List<AttributeBase> attributes { get; set; }
        public List<ItemBase> itemsUsed { get; set; }
        public List<Resistance> resistances { get; set; }

    }
}
