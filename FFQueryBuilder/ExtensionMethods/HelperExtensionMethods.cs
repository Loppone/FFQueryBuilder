using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFQueryBuilder
{
    public static class HelperExtensionMethods
    {
        public static string ToFormattedString(this IDictionary<string, DbContext> dbContexts)
        {
            return String.Join(Environment.NewLine, dbContexts.Select(x => $"{x.Key}, {x.Value}"));
        }
    }
}
