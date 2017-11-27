using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityBase
    {
        [Key]
        public int id { get; set; }
        public User createdBy { get; set; }
        public bool deleted { get; set; }
    }
}
