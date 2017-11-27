using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DAO
{
    public class Singleton
    {
        private static Context context;

        public static Context getInstance()
        {
            if (context == null)
            {
                context = new Context();
                return context;
            }
            else
            {
                return context;
            }
        }
    }
}
