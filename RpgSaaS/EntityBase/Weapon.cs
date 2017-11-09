using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBase
{
    class Weapon : Item
    {
        public override CharacterBase applyEffect(CharacterBase character)
        {
            return character;
        }
    }
}
