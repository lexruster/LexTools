using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Dapper;

namespace LexTools.Database
{
    public class Repository<T> : IRepository<T> where T : BaseDbEntity
    {
        protected readonly IDbConnectionProvider ConnectionProvider;

        public Repository(IDbConnectionProvider connectionProvider)
        {
            ConnectionProvider = connectionProvider;
        }

        public T Get(int id)
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                return connection.Get<T>(id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                return connection.GetList<T>().ToArray();
            }
        }

        public IEnumerable<T> GetList(object condition)
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                return connection.GetList<T>(condition).ToArray();
            }
        }

        public IEnumerable<T> GetQueryList(string query, object condition)
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                return connection.Query<T>(query, condition).ToArray();
            }
        }

        public int Add(T entity)
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                return Insert(entity, connection);
            }
        }

        public void Add(IEnumerable<T> entities)
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                foreach (T entity in entities)
                {
                    Insert(entity, connection);
                }
            }
        }

        private int Insert(T entity, DbConnection connection)
        {
            int id = connection.Insert<int, T>(entity);
            entity.Id = id;
            return id;
        }

        public void Update(T entity)
        {
            using (var connection = ConnectionProvider.GetConnection())
            {
                connection.Update(entity);
            }
        }
    }
}