using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CharacterBase : EntityBase
    {
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int MaxSp { get; set; }
        public float CurrentHp { get; set; }
        public float CurrentMp { get; set; }
        public float CurrentSp { get; set; }
        public List<AttributeBase> Attributes { get; set; }
        public List<ItemBase> ItemsUsed { get; set; }
        public List<Resistance> Resistances { get; set; }

        public CharacterBase()
        {
            Attributes = new List<AttributeBase>();
            ItemsUsed = new List<ItemBase>();
            Resistances = new List<Resistance>();
        }

    }
}
