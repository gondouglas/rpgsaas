using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DB
{
    public class DB
    {
        public List<User> Users { get; set; }

        public DB()
        {
            Users = new List<User>();
        }
    }
}
