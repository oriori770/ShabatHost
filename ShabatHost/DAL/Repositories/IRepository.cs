using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatHost.DAL.Repositories
{
    internal interface IRepository<T>
    {
        List<T> FindAll();
        T FindById(int id);
        T ValueAt(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
