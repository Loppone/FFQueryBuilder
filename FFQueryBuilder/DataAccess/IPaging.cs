using FFQueryBuilder.Models;

namespace FFQueryBuilder.DataAccess
{
    public interface IPaging
    {
        dynamic GetData(string contextName, string tableName, Paging page);
    }
}
