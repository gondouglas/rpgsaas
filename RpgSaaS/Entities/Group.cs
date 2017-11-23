using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Group : EntityBase
    {
        public List<Enemy> enemies { get; set; }
    }
}
