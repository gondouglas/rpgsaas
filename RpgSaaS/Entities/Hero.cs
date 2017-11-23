using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hero : CharacterBase
    {
        public Level level { get; set; }
        public Inventory inventory { get; set; }

    }
}
