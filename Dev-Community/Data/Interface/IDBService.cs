using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Community.Data
{

    public interface IDBService<T>
    {
        Task<T> Get(string ID);
        Task<T> Add(T item);
        Task<T> Remove(T item);
        Task<T> Update(T item);
        Task<List<T>> GetAll();
    }

    public class DBServiceClass
    {
        protected readonly developtiveContext context;
        protected DBServiceClass(developtiveContext _context)
        {
            context = _context;
        }
    }
}
