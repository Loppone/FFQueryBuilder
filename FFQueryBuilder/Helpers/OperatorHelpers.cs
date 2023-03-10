using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FFQueryBuilder.Helpers
{
    public class OperatorHelpers
    {
        /// <summary>
        /// Legge da un file di configurazione l'elenco dei tipi
        /// </summary>
        /// <returns></returns>
        /// <TODO>implementare il metodo con OCP</TODO>
        public static Dictionary<string, IEnumerable<CompareOperator>> OperatorsByType()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(assemblyPath, "Data/OperatorsByType.json");
            var jsonText = File.ReadAllText(filePath);

            var dict = JsonConvert.DeserializeObject<Dictionary<string, IEnumerable<CompareOperator>>>(jsonText);

            return dict;
        }
    }
}
