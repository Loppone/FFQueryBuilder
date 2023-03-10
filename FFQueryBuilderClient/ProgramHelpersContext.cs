using FF3DContexts.OracleModels;
using FF3DContexts.SqlModels;
using FFQueryBuilder;
using FFQueryBuilder.Context;
using System;

namespace FFQueryBuilderClient
{


    internal static class ProgramHelpersContext
    {
        //public static void SimpleCall()
        //{
        //    // Connessione al database SQL Server
        //    var connectionString = "Data Source=RKPSQL01DEV.intra.manutencoop.tst\\DEV;Initial Catalog=FORNITORI;Persist Security Info=True;User ID=svc_fornitori;Password=espfLO77!";
        //    var connection = new SqlConnection(connectionString);

        //    // Query per selezionare le tabelle del database
        //    var commandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
        //    var command = new SqlCommand(commandText, connection);
        //    connection.Open();
        //    var reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        var tableName = reader.GetString(0);

        //        // Query per selezionare le colonne della tabella
        //        var columnsCommandText = "SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName";
        //        var columnsCommand = new SqlCommand(columnsCommandText, connection);
        //        columnsCommand.Parameters.AddWithValue("@tableName", tableName);

        //        // Chiusura del lettore dati corrente prima di eseguire la nuova query
        //        //reader.Close();

        //        var columnsReader = columnsCommand.ExecuteReader();

        //        Console.WriteLine($"Tabella: {tableName}");
        //        Console.WriteLine("----------------------------------");

        //        while (columnsReader.Read())
        //        {
        //            var columnName = columnsReader.GetString(0);
        //            var dataType = columnsReader.GetString(1);
        //            var isNullable = columnsReader.GetString(2) == "YES";

        //            Console.WriteLine($"Nome colonna: {columnName}");
        //            Console.WriteLine($"Tipo di dati: {dataType}");
        //            Console.WriteLine($"Nullable: {isNullable}");
        //            Console.WriteLine("----------------------------------");
        //        }

        //        columnsReader.Close();
        //    }

        //    reader.Close();
        //    connection.Close();

        //    Console.ReadLine();
        //}

        public static void SimpleCall()
        {
            // *** V1 
            // Simulo la configurazione delle webapi, tipo:
            //public void ConfigureServices(IServiceCollection services)
            //{
            //    var dbContexts = new Dictionary<string, DbContext>
            //    {
            //        { "Oracle", new MyDbContextOracle() },
            //        { "SqlServer", new MyDbContextSqlServer() }
            //        // Aggiungi qui altri DbContext con i rispettivi nomi
            //    };

            //    services.AddSingleton<IDictionary<string, DbContext>>(dbContexts);
            //    services.AddSingleton<IDbContextFactory, MyDbContextFactory>();
            //    services.AddControllers();
            //}

            //var dbContexts = new Dictionary<string, DbContext>
            //    {
            //        { "Oracle", new MyDbContextOracle() },
            //        { "SqlServer", new MyDbContextSqlServer() }
            //    };

            // *** V2
            // Cambiato idea. Isolo EF nella dll
            // WebApi agnostiche. Ad ogni cliente viene distribuita la dll del core comprensiva di contesti custom.

            // I modelli dei db li passo nel client avendo un riferimento alla dll apposita per cliente

            // ******
            // Vedere API GetDataController
            // ******
        }

        public static void GetContextsConfiguration()
        {
            // Simulazione config in startup delle web api
            DbContextFactory.Instance.AddDbContext("SqlServer", new FORNITORIContext());
            DbContextFactory.Instance.AddDbContext("Oracle", new ModelContext());

            var r = DbContextHelper.GetConfiguredContexts();
        }

        public static void GetTableInfo()
        {
            using (var context = new ModelContext())
            {
                var temp = context.Model.GetEntityTypes();

                var columns = context.Model.FindEntityType("FF3DContexts.OracleModels.Woreq").GetProperties();
                foreach (var column in columns)
                {
                    var columnName = column.Name;
                    var columnType = column.GetTypeMapping().ClrType.Name; // column.ClrType.Name;
                    var columnNullable = column.IsNullable;
                    var columnPK = column.IsPrimaryKey();
                    var columnLength = column.GetMaxLength();
                    Console.WriteLine($"{columnName}: {columnType} - Nullable: {columnNullable} - PK: {columnPK} - Length: {columnLength}");
                }
            }

        }

        public static void DynamicContextCreation()
        {
            //var scaffolder = CreateMssqlScaffolder();
        }

        //private static object CreateMssqlScaffolder() =>
        //    new ServiceCollection()
        //    .AddEntityFrameworkSqlServer()
        //    .AddLogging()
        //    //.AddEntityFrameworkDesignTimeServices();
        //    .AddSingleton<LoggingDefinitions, SqlServerLoggingDefinitions>()
        //    .AddSingleton<IRelationalTypeMappingSource, SqlServerTypeMappingSource>()
        //    .AddSingleton<IAnnotationCodeGenerator, AnnotationCodeGenerator>()
        //    .AddSingleton<IDatabaseModelFactory, SqlServerDatabaseModelFactory>()
        //    .AddSingleton<IProviderConfigurationCodeGenerator, SqlServerCodeGenerator>()
        //    //.AddSingleton<IScaffoldingModelFactory, RelationalScaffoldingModelFactory>()
        //    //.AddSingleton<IPluralizer, Bricelam.EntityFrameworkCore.Design.Pluralizer>()
        //    .BuildServiceProvider()
        //    .GetRequiredService<ScaffoldingDbContext>();
    }
}
