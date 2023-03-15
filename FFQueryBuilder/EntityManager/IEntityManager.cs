using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder.BusinessLogic
{
    public interface IEntityManager
    {
        public string ContextName { get; set; }
        public string EntityName { get; set; }
        public dynamic EntityValues { get; set; }
        public dynamic Entity { get; set; }
        public DbContext Context { get; set; }

        void CreateEntityInstance(Dictionary<string, object> properties);
    }
}
