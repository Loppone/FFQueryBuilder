using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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