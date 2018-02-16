using System.Data.Common;

namespace LexTools.Database
{
    public interface IDbConnectionProvider
    {
        DbConnection GetConnection();
    }
}