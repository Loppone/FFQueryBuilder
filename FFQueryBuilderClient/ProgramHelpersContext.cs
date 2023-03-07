using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Internal;
using System.Data.Entity;
using FFQueryBuilder;
using FFQueryBuilder.Context;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using FF3DContexts.SqlModels;
using FF3DContexts.OracleModels;
using FFQueryBuilder.Models;
using FFQueryBuilder.DataAccess;
using System.Reflection;

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

            var whatInside = DbContextFactory.AddDbContext("SqlServer", new FORNITORIContext());
            Console.WriteLine(whatInside.ToFormattedString());

            Console.WriteLine();

            whatInside = DbContextFactory.AddDbContext("Oracle", new ModelContext());
            Console.WriteLine(whatInside.ToFormattedString());

            var fornitori = DbContextFactory.GetDbContext("SqlServer");
            var mp2 = DbContextFactory.GetDbContext("Oracle");

            var dbSets = fornitori.GetType().GetProperties()
                .Where(prop => prop.PropertyType.IsGenericType && prop.PropertyType.Name.ToLower().Contains("dbset"))
                .Select(ptype => ptype.PropertyType.GetGenericArguments()[0])
                .ToList();

            var mp2dbSets = mp2.GetType().GetProperties()
                .Where(prop => prop.PropertyType.IsGenericType && prop.PropertyType.Name.ToLower().Contains("dbset"))
                .Select(ptype => ptype.PropertyType.GetGenericArguments()[0])
                .ToList();

            dbSets.AddRange(mp2dbSets);

            var pageDto = new Paging();
            pageDto.Filters = new List<FilterItem>()
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
            pageDto.Order = new OrderItem()
            {
                Field = "REQUESTNUM",
                TypeOfOrder = OrderType.Ascendente
            };
            pageDto.CurrentPage = 1;
            pageDto.ItemPerPage = 5;

            IPaging data = new PagingQuery();

            var dt = data.GetData(mp2, dbSets, "Woreq", pageDto);

            var ttt = Newtonsoft.Json.JsonConvert.SerializeObject(dt);
        }
    }
}
