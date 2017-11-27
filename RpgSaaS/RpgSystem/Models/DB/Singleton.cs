using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DB
{
    class Singleton
    {

        private static DB db = new DB();

        public static DB getInstance()
        {
            if (db == null)
            {
                db = new DB();
                return db;
            }
            else
                return db;
        }
    }
}
