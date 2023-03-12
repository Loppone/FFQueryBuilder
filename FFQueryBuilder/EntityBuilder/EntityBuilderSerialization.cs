using FFQueryBuilder.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.EntityBuilder
{
    public class EntityBuilderSerialization : IEntityBuilder
    {
        public string EntityName { get; set; }
        public Dictionary<string, object> SourceFields { get; set; }

        public EntityBuilderSerialization()
        {
        }

        public dynamic Build()
        {
            // Devo usare il serializzatore di Microsoft perchè aggiunge una struttura (ValueKind) che NewtonSoft non legge.
            string json = System.Text.Json.JsonSerializer.Serialize(SourceFields);

            var entityType = TypeHelper.GetTypeByName(EntityName);
            dynamic entityInstance = Activator.CreateInstance(entityType);

            return Deserialize(entityInstance, json);
        }

        private T Deserialize<T>(T obj, string json)
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
    }
}
