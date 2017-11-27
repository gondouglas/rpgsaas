using Entities;
using RpgSystem.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.DAO
{
    public class UserDAO : IDAO<User>
    {
        public static Context ctx = Singleton.getInstance();

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
            return ctx.Users.ToList();
        }

        public List<User> List(string where)
        {
            throw new NotImplementedException();
        }

        public User Remove(User t)
        {
            ctx.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
            return t;
        }

        public void Save(User t)
        {
            ctx.Users.Add(t);
            ctx.SaveChanges();
        }

        public User Update(User t)
        {
            ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
            return t;
        }
    }
}
