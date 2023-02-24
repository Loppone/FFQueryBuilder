using FFQueryBuilder;
using FFQueryBuilderClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace FFQueryBuilderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new FORNITORIContext())
            {
                Console.Clear();

                ProgramHelpers.SimpleQuery(ctx);
                ProgramHelpers.SimpleQueryDateBetween(ctx);
                ProgramHelpers.QueryWithSelectFields(ctx);

                Console.ReadKey();
            }
        }
    }
}
