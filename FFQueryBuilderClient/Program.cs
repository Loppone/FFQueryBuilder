using System;

namespace FFQueryBuilderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Clear();

            //using (var ctx = new FORNITORIContext())
            //{

            //    //ProgramHelpers.SimpleQuery(ctx);
            //    //ProgramHelpers.SimpleQueryDateBetween(ctx);
            //    //ProgramHelpers.QueryWithSelectFields(ctx);
            //    //ProgramHelpers.SqlDataTypeQuery(ctx);
            //}

            //    //ProgramHelpersContext.SimpleCall();
            //    //ProgramHelpers.ListFilter();

            //ProgramHelpersContext.GetContextsConfiguration();
            
            ProgramHelpersContext.GetTableInfo();

            Console.ReadKey();
        }
    }
}
