using FFQueryBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace FFQueryBuilder.EntityBuilder
{
    public class EntityBuilderSerialization : IEntityBuilder
    {
        private readonly JsonSerializerOptions _options =
            new JsonSerializerOptions
            {
                //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };
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
            var r = System.Text.Json.JsonSerializer.Deserialize<T>(json, _options);

            return r;
        }
    }
}
