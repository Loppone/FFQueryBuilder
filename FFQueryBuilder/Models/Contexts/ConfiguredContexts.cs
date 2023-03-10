using System.Collections.Generic;

namespace FFQueryBuilder.Models.Contexts
{
    public class ConfiguredContexts
    {
        public string ContextName { get; set; }
        public IEnumerable<string> Entities { get; set; }
    }
}
