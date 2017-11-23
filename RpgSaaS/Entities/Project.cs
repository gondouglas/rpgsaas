using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Project : EntityBase
    {
        public string name { get; set; }
        public string description { get; set; }
        public DateTime creationDate { get; set; }
        public List<CharacterBase> characters { get; set; }
        public List<ItemBase> items { get; set; }
        public List<Group> groups { get; set; }
        public List<AttributeBase> attributes { get; set; }
    }
}
