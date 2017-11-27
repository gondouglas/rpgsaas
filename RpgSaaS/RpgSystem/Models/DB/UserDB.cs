using Entities;
using RpgSystem.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DB
{
    class UserDB : IDAO<User>
    {
        DB db = Singleton.getInstance();
        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetDeleted()
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            return db.Users;
        }

        public List<User> List(string where)
        {
            throw new NotImplementedException();
        }

        public User Remove(User t)
        {
            throw new NotImplementedException();
        }

        public void Save(User t)
        {
            db.Users.Add(t);
        }

        public User Update(User t)
        {
            int i;
            for (i=0; i < db.Users.Count; i++)
            {
                if (db.Users[i].Login == t.Login)
                {
                    db.Users[i] = t;
                    break;
                }
            }
            return db.Users[i];
        }
    }
}
