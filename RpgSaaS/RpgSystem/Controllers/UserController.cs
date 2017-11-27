using Entities;
using RpgSystem.DAO;
using RpgSystem.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Controllers
{
    public class UserController
    {


        public void Save(User user)
        {
            List<string> texts = new List<string>()
                {
                    user.Name,user.Lastname,user.Login,user.Password
                };
            if (fieldsInvalid(texts))
            {
                throw new Exception("No field can be blank!");
            }
            if (LoginCheck(user.Login))
            {
                throw new Exception("Login already exists!");
            }
            FactoryDAO.getUserDAO().Save(user);
        }

        public void Update(User user)
        {
            FactoryDAO.getUserDAO().Update(user);
        }

        public List<User> toList()
        {
            return FactoryDAO.getUserDAO().List();
        }

        public User GetUser(string login, string password)
        {
            foreach (User user in toList())
            {
                if (login == user.Login && password == user.Password)
                {
                    return user;
                }
            }
            return null;
        }

        private bool LoginCheck(string login)
        {
            foreach (User user in toList())
            {
                if (login == user.Login)
                {
                    return true;
                }
            }
            return false;
        }

        private bool fieldsInvalid(List<string> texts)
        {
            foreach (string text in texts)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
