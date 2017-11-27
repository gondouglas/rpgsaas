using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Project : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public List<CharacterBase> Characters { get; set; }
        public List<ItemBase> Items { get; set; }
        public List<Group> Groups { get; set; }
        public List<TypeItem> TypeItems { get; set; }
        public List<AttributeBase> Attributes { get; set; }

        public Project()
        {
            CreationDate = DateTime.Now;
            Characters = new List<CharacterBase>();
            Items = new List<ItemBase>();
            Groups = new List<Group>();
            Attributes = new List<AttributeBase>();
            TypeItems = new List<TypeItem>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
