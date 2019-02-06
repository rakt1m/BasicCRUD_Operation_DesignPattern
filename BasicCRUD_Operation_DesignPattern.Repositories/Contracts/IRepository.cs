using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRUD_Operation_DesignPattern.Repositories.Contracts
{
    public interface IRepository<T> where T:class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);

        T GetById(int? id);
        ICollection<T> GetAll();
    }
}
