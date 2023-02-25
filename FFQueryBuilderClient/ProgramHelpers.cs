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
    }
}