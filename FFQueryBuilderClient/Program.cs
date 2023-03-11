using System;

namespace FFQueryBuilderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //    //ProgramHelpers.SimpleQuery(new FORNITORIContext());
            //    //ProgramHelpers.SimpleQueryDateBetween(new FORNITORIContext());
            //    //ProgramHelpers.QueryWithSelectFields(new FORNITORIContext());
            //    //ProgramHelpers.SqlDataTypeQuery(new FORNITORIContext());
            //    //ProgramHelpers.ListFilter();

            ProgramHelpersContext.InitializeProgram();

            //ProgramHelpersContext.SimpleCall();
            //ProgramHelpersContext.GetContextsConfiguration();
            //ProgramHelpersContext.GetTableInfo();
            //var c = FFQueryBuilder.Helpers.OperatorHelpers.OperatorsByType();

            //ProgramHelpersContext.AddEntity();

            ProgramHelpersContext.CreateEntity();

            //Console.ReadKey();
        }
    }
}
