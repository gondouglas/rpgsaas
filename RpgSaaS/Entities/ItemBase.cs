using System.Collections.Generic;

namespace Entities
{
    public class ItemBase : EntityBase
    {
        public string name { get; set; }
        public string description { get; set; }
        public TypeItem type { get; set; }
        public List<AttributeBase> attributesInfluenced { get; set; }
    }
}