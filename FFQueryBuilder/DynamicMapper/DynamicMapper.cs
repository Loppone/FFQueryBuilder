using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FFQueryBuilder.DynamicMapper
{
    public class DynamicMapper
    {
        private readonly IDbContextManager _contextManager;

        public DynamicMapper(IDbContextManager contextManager)
        {
            _contextManager = contextManager;
        }

        public dynamic Map(dynamic source, DbContext context, dynamic entity, string contextName, string entityName)
        {
            var destinationObject = _contextManager.GetInternalType(context, entityName);
            var destinationProperties = destinationObject.GetType().GetProperties();
            var sourceProperties = source.GetType().GetProperties();

            // TODO: Trovare un modo più efficace per ricercare una proprietà
            foreach (var sourceProperty in sourceProperties)
            {
                foreach (var destinationProperty in destinationProperties)
                {
                    if (destinationProperty.Name == sourceProperty.Name)
                    {
                        destinationProperty.SetValue(destinationObject, sourceProperty.GetValue(source, null), null);
                        break;
                    }
                }
            }

            return destinationObject;
        }
    }
}
