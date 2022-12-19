using System.Collections.Generic;

namespace Store.Application.Common.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetItemById(int id);
        void Create(T item);

        IEnumerable<T> Where(System.Func<T, bool> predicate);

        void Update(T item);
        void Delete(int id);
        void Delete(T item);
    }
}
