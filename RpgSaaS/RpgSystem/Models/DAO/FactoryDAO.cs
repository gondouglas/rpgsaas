using Entities;
using RpgSystem.DAO;
using RpgSystem.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DAO
{
    public class FactoryDAO
    {
        public static IDAO<User> getUserDAO()
        {
            UserDB userDB = new UserDB();
            return userDB;
        }
    }
}
