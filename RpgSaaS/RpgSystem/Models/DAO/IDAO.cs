using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem.Models.DAO
{
    public interface IDAO<T>
    {
        void Save(T t);
        List<T> List();
        List<T> List(string where);
        T Update(T t);
        T Remove(T t);
        T GetById(int id);
        List<T> GetDeleted();
        
    }
}
