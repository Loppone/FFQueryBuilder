using FFQueryBuilder;
using FFQueryBuilderClient.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFQueryBuilderClient
{
    internal static class ProgramHelpers
    {

        public static void QueryWithSelectFields(FORNITORIContext ctx)
        {
            Console.WriteLine("Query con proiezione dei campi");

            var filtri = new List<FFQueryBuilder.FilterItem>();

            filtri.Add(new FilterItem()
            {
                Field = "IdGruppoValidazione",
                Value = "1",
                Operator = CompareOperator.Uguale
            });

            filtri.Add(new FilterItem()
            {
                Field = "NomeCognome",
                Value = "Sala",
                Operator = CompareOperator.Contiene
            });

            var order = new OrderItem()
            {
                Field = "NomeCognome",
                TypeOfOrder = OrderType.Discendente
            };

            var q = ctx.FrnUtentis
                .Select(x => new Utenti()
                {
                    UserAd = x.Userad,
                    IdGruppoValidazione = x.FrnUtentiGruppiValidaziones.FirstOrDefault().IdGruppoValidazione,
                    LivelloAutorizzazione = x.LivelloAutorizzazione,
                    Nomecognome = x.Nomecognome,
                    Visualizzareport = x.Visualizzareport
                })
                .FilterBy(filtri)
                .OrderByField(order);

            var qs = q.ToQueryString();
            var res = q.ToList();

            Console.WriteLine($"Righe trovate: {res.Count()}");
            Console.WriteLine();
        }

        internal static void SimpleQueryDateBetween(FORNITORIContext ctx)
        {
            Console.WriteLine("Query semplice con filtro tra due date");

            var filtri = new List<FFQueryBuilder.FilterItem>();

            filtri.Add(new FilterItem()
            {
                Field = "DataRichiesta",
                Value = "2014-04-23 09:24:53.133",
                Operator = CompareOperator.Maggiore
            });

            filtri.Add(new FilterItem()
            {
                Field = "DataRichiesta",
                Value = "2014-05-23 09:24:53.133",
                Operator = CompareOperator.Minore
            });

            var order = new OrderItem()
            {
                Field = "DataRichiesta",
                TypeOfOrder = OrderType.Ascendente
            };

            var q = ctx.FrnDocumentos
                .FilterBy(filtri)
                .OrderByField(order);

            var qs = q.ToQueryString();
            var res = q.ToList();

            Console.WriteLine($"Righe trovate: {res.Count()}");
            Console.WriteLine();
        }

        internal static void SimpleQuery(FORNITORIContext ctx)
        {
            Console.WriteLine("Query Semplice");

            var filtri = new List<FFQueryBuilder.FilterItem>();

            filtri.Add(new FilterItem()
            {
                Field = "DataValidazione",
                Value = "2021-12-21 00:00:00.000",
                Operator = CompareOperator.Uguale
            });

            var order = new OrderItem()
            {
                Field = "DataRichiesta",
                TypeOfOrder = OrderType.Ascendente
            };

            var q = ctx.FrnDocumentos
                .FilterBy(filtri)
                .OrderByField(order);

            var qs = q.ToQueryString();
            var res = q.ToList();

            Console.WriteLine($"Righe trovate: {res.Count()}");
            Console.WriteLine();
        }

        internal static void SqlDataTypeQuery(FORNITORIContext ctx)
        {
            Console.WriteLine("Query con filtri di tipo derivante da Sql Server. Lista filtri su tipi dati:");
            Console.WriteLine("Long/Float/Object/TimeSpan/Byte/DateTimeOffset");

            var filtri = new List<FFQueryBuilder.FilterItem>()
            {
                new FilterItem() { Field = "Bigint", Value = "123", Operator = CompareOperator.Maggiore },
                new FilterItem() { Field = "Float", Value = "3,14", Operator = CompareOperator.Uguale },
                new FilterItem() { Field = "SqlVariant", Value = "11", Operator = CompareOperator.Diverso },
                new FilterItem() { Field = "Time", Value = new TimeSpan(1, 30, 0).ToString(), Operator = CompareOperator.Maggiore },
                new FilterItem() { Field = "TinyInt", Value = "255", Operator = CompareOperator.Minore },
                new FilterItem() { Field = "DateTimeOffset", Value = DateTimeOffset.Now.ToString(), Operator = CompareOperator.MinoreUguale }
            };

            var q = ctx.TempAllTypes
                .FilterBy(filtri);

            var qs = q.ToQueryString();
            var res = q.ToList();

            Console.WriteLine($"Righe trovate: {res.Count()}");
            Console.WriteLine();
        }

        internal static void ListFilter()
        {
            Console.WriteLine("Filtri applicati ad una Lista in memoria");

            var filtri = new List<FFQueryBuilder.FilterItem>()
            {
                new FilterItem() { Field = "Bigint", Value = "123", Operator = CompareOperator.Maggiore },
                new FilterItem() { Field = "Float", Value = "3,14", Operator = CompareOperator.Uguale },
                new FilterItem() { Field = "SqlVariant", Value = "11", Operator = CompareOperator.Diverso },
                new FilterItem() { Field = "Time", Value = new TimeSpan(1, 30, 0).ToString(), Operator = CompareOperator.Maggiore },
                new FilterItem() { Field = "TinyInt", Value = "255", Operator = CompareOperator.Minore },
                new FilterItem() { Field = "DateTimeOffset", Value = DateTimeOffset.Now.ToString(), Operator = CompareOperator.MinoreUguale }
            };

            var lista = new List<TempAllType>()
            {
                new TempAllType(){BigInt=10, Float=3.14, SqlVariant="ciao", Time=new TimeSpan(1, 30, 0), TinyInt=55, DatetimeOffset=DateTimeOffset.Now.AddDays(1)},
                new TempAllType(){BigInt=190, Float=333.51, SqlVariant="123", Time=new TimeSpan(2, 10, 40), TinyInt=12, DatetimeOffset=DateTimeOffset.Now.AddDays(5)},
                new TempAllType(){BigInt=810, Float=3.14, SqlVariant="hola", Time=new TimeSpan(10, 50, 10), TinyInt=43, DatetimeOffset=DateTimeOffset.Now.AddDays(-1)},
                new TempAllType(){BigInt=180, Float=123.23, SqlVariant="", Time=new TimeSpan(4, 45, 0), TinyInt=99, DatetimeOffset=DateTimeOffset.Now.AddDays(-4)},
                new TempAllType(){BigInt=4, Float=654.11, SqlVariant="p0p0", Time=new TimeSpan(3, 12, 34), TinyInt=254, DatetimeOffset=DateTimeOffset.Now.AddDays(8)},
                new TempAllType(){BigInt=124, Float=3.14, SqlVariant=null, Time=new TimeSpan(2, 05, 0), TinyInt=133, DatetimeOffset=DateTimeOffset.Now.AddDays(-12)}
            };

            var q = lista
                .AsQueryable()
                .FilterBy(filtri);

            var res = q.ToList();

            Console.WriteLine($"Righe trovate: {res.Count()}");
            Console.WriteLine();
        }
    }
}