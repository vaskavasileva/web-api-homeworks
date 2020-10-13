using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        bool Create(T entity);
        bool Delete(int id);
        bool Update(T entity);
    }
}
