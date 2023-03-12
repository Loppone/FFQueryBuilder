using FFQueryBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FFQueryBuilder.EntityBuilder
{
    /// <summary>
    /// Crea un oggetto a partire da una struttura chiave/valore
    /// </summary>
    public class EntityBuilder : IEntityBuilder
    {
        private readonly ITypeConverter _typeConverter;

        public string EntityName { get; set; }
        public Dictionary<string, object> SourceFields { get; set; }

        public EntityBuilder(ITypeConverter typeConverter)
        {
            _typeConverter = typeConverter;
        }

        public dynamic Build()
        {
            var entityType = TypeHelper.GetTypeByName(EntityName);
            var obj = Activator.CreateInstance(entityType);

            foreach (var field in SourceFields)
            {
                PropertyInfo propertyInfo = entityType.GetProperty(field.Key);
                if (propertyInfo != null && propertyInfo.CanWrite)
                {
                    var value = _typeConverter.Convert(field.Value, propertyInfo.PropertyType);
                    propertyInfo.SetValue(obj, value, null);
                }
            }

            return obj;
        }
    }
}
