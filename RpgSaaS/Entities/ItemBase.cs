using System.Collections.Generic;

namespace Entities
{
    public class ItemBase : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeItem Type { get; set; }
        public List<AttributeBase> AttributesInfluenced { get; set; }

        public ItemBase()
        {
            AttributesInfluenced = new List<AttributeBase>();
        }
    }
}