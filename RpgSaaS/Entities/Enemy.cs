using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Enemy : CharacterBase
    {
        public int DropExp { get; set; }
        public int DropMoney { get; set; }
        public List<Loot> Loot { get; set; }

        public Enemy()
        {
            Loot = new List<Loot>();
        }
    }
}
