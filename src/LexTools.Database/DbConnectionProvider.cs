using System.Data.Common;
using System.Data.SqlClient;

namespace LexTools.Database
{
    public class DbConnectionProvider : IDbConnectionProvider
    {
        private readonly string _connectionString;
        public DbConnectionProvider(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DbConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            return connection;
        }
    }
}