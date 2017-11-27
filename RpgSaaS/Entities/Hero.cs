using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hero : CharacterBase
    {
        public Level Level { get; set; }
        public Inventory Inventory { get; set; }

        public Hero()
        {
            Level = new Level();
            Inventory = new Inventory();
        }
    }
}
