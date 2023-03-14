using FFQueryBuilder.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder
{
    public interface IDbContextManager
    {
        IEnumerable<ConfiguredContexts> GetConfiguredContexts();
        IEnumerable<ModelInfo> EntityInformation(string contextName, string entityName);
        dynamic GetEntityFrameworkDbSet(DbContext context, string table);
        dynamic GetInternalType(DbContext context, string table);
        KeyValuePair<string, object> PrimaryKeyValue(DbContext context, dynamic entity);
    }
}
