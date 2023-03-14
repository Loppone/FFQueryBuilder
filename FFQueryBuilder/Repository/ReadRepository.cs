using FF3DContexts.SqlModels;
using FFQueryBuilder.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace FFQueryBuilder.Repository
{
    public class ReadRepository : IReadableRepository
    {
        private readonly IDbContextManager _dbContextManager;

        public DbContext Context { get; set; }
        public dynamic Entity { get; set; }
        public string ContextName { get; set; }
        public string EntityName { get; set; }

        public ReadRepository(IDbContextManager dbContextManager)
        {
            _dbContextManager = dbContextManager;
        }

        /// <summary>
        /// Ottiene il record che ha il campo pk = id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public dynamic GetById(object id)
        {
            var pkProperty = _dbContextManager.EntityInformation(ContextName, EntityName)?
                .FirstOrDefault(x => x.IsPrimaryKey)?.Name;

            if (pkProperty == null)
                return null;

            return Query.GetById(Context, Entity, pkProperty, id.ToString());
        }

        /// <summary>
        /// Torna l'occorrenza del primo record trovato in base ai filtri passati in input
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>        
        public dynamic First(Dictionary<string, object> filter)
        {
            return Query.GetByMultipleFields(Context, Entity, filter);
        }
    }
}