using System;
using System.Linq;

namespace FFQueryBuilder.Helpers
{
    internal class TypeHelper
    {
        /// <summary>
        /// Ricerca il tipo in tutti gli assembly in base al nome senza i namespace
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// <TODO>La ricerca avviene negli assembly che iniziano con FF3DContexts. Togliere questo vincolo.</TODO>
        internal static Type GetTypeByName(string typeName)
        {
            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .ToList();

            foreach (var assembly in assemblies)
            {
                Type[] types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if (type.Name == typeName && type.FullName.StartsWith("FF3DContexts."))
                    {
                        return type;
                    }
                }
            }

            throw new Exception("Tipo non trovato");
        }
    }
}
