using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBase
{
    class Game
    {
        public List<CharacterBase> characters { get; set; }
        public List<Item> items { get; set; }

        public string createdby { get; set; }
    }
}
