using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using FFQueryBuilder;

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



            var aliasDbContextPassatoDalClient = "SqlServer";
            var fornitori = DbContextFactory.Instance.CreateDbContext(aliasDbContextPassatoDalClient);

            var mp2 = DbContextFactory.Instance.CreateDbContext("Oracle");

            var dbSets = new List<Type>();
            var properties = fornitori.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propertyType = property.PropertyType;
                if (propertyType.IsGenericType && propertyType.Name.ToLower().Contains("dbset"))
                {
                    Type dbSetType = propertyType.GenericTypeArguments[0];
                    dbSets.Add(dbSetType);
                }
            }

            var propertiesOracle = mp2.GetType().GetProperties();
            foreach (var property in propertiesOracle)
            {
                var propertyType = property.PropertyType;
                if (propertyType.IsGenericType && propertyType.Name.ToLower().Contains("dbset"))
                {
                    Type dbSetType = propertyType.GenericTypeArguments[0];
                    dbSets.Add(dbSetType);
                }
            }


            var filtro0 = new List<FilterItem>()
                {
                    new FilterItem()
                    {
                        Field = "SITEID",
                        Value = "TESTCC",
                        Operator = CompareOperator.Uguale
                    },
                    new FilterItem()
                    {
                        Field = "TASKNUM",
                        Value = "AAAQ",
                        Operator =  CompareOperator.Uguale
                    }
                };
            var tipoSql0 = dbSets.FirstOrDefault(x => x.Name.Contains("Woreq")); // Sql
            Type tipoInternoEFForSql0 = typeof(InternalDbSet<>).MakeGenericType(tipoSql0);
            dynamic istanzaSql0 = Activator.CreateInstance(tipoInternoEFForSql0, mp2, tipoSql0.Name);
            var sqlData = GetData(mp2, istanzaSql0, filtro0, 0, 10);




            //var filtro1 = new List<FilterItem>()
            //    {
            //        new FilterItem()
            //        {
            //            Field = "SiteId",
            //            Value = "TESTCC",
            //            Operator = CompareOperator.Uguale
            //        }
            //    };
            //var tipoSql = dbSets.FirstOrDefault(x=>x.Name.Contains("FrnUtenti")); // Sql
            //Type tipoInternoEFForSql = typeof(InternalDbSet<>).MakeGenericType(tipoSql);
            //dynamic istanzaSql = Activator.CreateInstance(tipoInternoEFForSql, fornitori, tipoSql.Name);
            //var sqlData =  GetData(fornitori, istanzaSql, filtro1, 0, 10);



            var filtro2 = new List<FilterItem>()
                {
                    new FilterItem()
                    {
                        Field = "nomedocumento",
                        Value = "durc",
                        Operator = CompareOperator.Uguale
                    }
                };
            var tipoSql2 = dbSets.FirstOrDefault(x => x.Name.Contains("FrnDocumento")); // Sql
            Type tipoInternoEFForSql2 = typeof(InternalDbSet<>).MakeGenericType(tipoSql2);
            dynamic istanzaSql2 = Activator.CreateInstance(tipoInternoEFForSql2, fornitori, tipoSql2.Name);
            var sqlData2 = GetData(fornitori, istanzaSql2, filtro2, 0, 10);
        }

        public static List<T> GetData<T>(
            DbContext db,
            Microsoft.EntityFrameworkCore.DbSet<T> _,
            List<FilterItem> filtri,
            int skip = 0,
            int size = 10000) where T : class
        {
            var q = db.Set<T>()
            .FilterBy(filtri)
            .Skip(skip + 1)
            .Take(size);

            var qs = q.ToQueryString();

            return q.ToList();
        }
    }
}
