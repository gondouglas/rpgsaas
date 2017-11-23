using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Enemy : CharacterBase
    {
        public int dropExp { get; set; }
        public int dropMoney { get; set; }
        public List<Loot> loot { get; set; }
    }
}
