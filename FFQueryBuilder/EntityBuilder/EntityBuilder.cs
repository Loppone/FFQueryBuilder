using FFQueryBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FFQueryBuilder.EntityBuilder
{
    /// <summary>
    /// Crea un oggetto a partire da una struttura chiave/valore
    /// </summary>
    internal class EntityBuilder : IEntityBuilder
    {
        private readonly string _entityName;
        public Dictionary<string,object> Properties { get; set; }

        public EntityBuilder(string entityName)
        {
            _entityName = entityName;
        }

        public dynamic Build()
        {
            var entityType = TypeHelper.GetTypeByName(_entityName);
            var obj = Activator.CreateInstance(entityType);

            foreach (var property in Properties)
            {
                PropertyInfo propertyInfo = entityType.GetProperty(property.Key);
                if (propertyInfo != null && propertyInfo.CanWrite)
                {
                    //object value = ConvertValue(property.Value, propertyInfo.PropertyType);
                    propertyInfo.SetValue(obj, property.Value, null);
                }
            }



            return obj;
        }
    }

    internal interface IEntityBuilder
    {
        dynamic Build();
    }
}
