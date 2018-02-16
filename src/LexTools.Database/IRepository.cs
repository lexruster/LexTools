using System.Collections.Generic;

namespace LexTools.Database
{
    public interface IRepository<T> where T : BaseDbEntity
    {
        T Get(int id);
        IEnumerable<T> GetList();
        IEnumerable<T> GetList(object condition);
        IEnumerable<T> GetQueryList(string query, object condition);
        int Add(T entity);
        void Add(IEnumerable<T> entities);
        void Update(T entity);
    }
}