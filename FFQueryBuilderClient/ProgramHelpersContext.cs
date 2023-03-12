using FF3DContexts.OracleModels;
using FFQueryBuilder;
using FFQueryBuilder.Context;
using FFQueryBuilder.EntityBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FFQueryBuilderClient
{


    internal static class ProgramHelpersContext
    {
        public static void InitializeProgram()
        {
            // Simulazione config in startup delle web api
            //DbContextFactory.Instance.AddDbContext("SqlServer", new FORNITORIContext());
            //DbContextFactory.Instance.AddDbContext("Oracle", new ModelContext());
        }

        internal static void CreateEntity()
        {
            //var builder = new EntityBuilder(new TypeConverter());
            var builder = new EntityBuilderSerialization();
            builder.EntityName = "FrnUtenti";

            builder.SourceFields = new System.Collections.Generic.Dictionary<string, object>
            {
                { "Userad", "mbertoli" },
                { "LivelloAutorizzazione", 1 },
                { "Nomecognome", "Max Bertoli" },
                { "Visualizzareport", false }
            };

            var myObject = builder.Build();

            //var factory = new DbContextFactory(new ServiceProvider())
            //var ctx = DbContextFactory.Instance.GetDbContext("SqlServer");
            //var dbSet = DbContextManager.GetDbSet(ctx, "FrnUtenti");

            //Add(ctx, dbSet, myObject);

            //ctx.SaveChanges();
        }

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
            //var r = DbContextManager.GetConfiguredContexts();
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

        internal static void AddEntity()
        {
            //var ctx = DbContextFactory.Instance.GetDbContext("SqlServer");
            //var dbSet = DbContextManager.GetDbSet(ctx, "FrnUtenti");

            //// Creare un nuovo oggetto FrnUtenti dinamicamente
            //var entity = Activator.CreateInstance(dbSet.GetType().GetGenericArguments()[0]);
            //var dynaType = entity.GetType();

            //dynaType.GetProperty("Userad").SetValue(entity, "mbertoli");
            //// Occhio al tipo: bisogna castare sul tipo corretto. In questo caso 1 è Int32, mentre la proprietà è short?
            //// Quindi quando si imposta il valore partendo da una stringa bisogna convertirlo nel tipo di dato della classe
            //dynaType.GetProperty("LivelloAutorizzazione").SetValue(entity, (short)1);
            //dynaType.GetProperty("Nomecognome").SetValue(entity, null);
            //dynaType.GetProperty("Visualizzareport").SetValue(entity, false);

            //Add(ctx, dbSet, entity);

            //ctx.SaveChanges();
        }

        private static void Add<T>(DbContext db, DbSet<T> _, T entity) where T : class
        {
            var q = db.Set<T>()
                .Add(entity);
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
