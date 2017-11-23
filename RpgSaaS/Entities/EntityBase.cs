using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityBase
    {
        public int id { get; set; }
        public User createdBy { get; set; }
        public bool deleted { get; set; }
    }
}
