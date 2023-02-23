using FFQueryBuilder;
using FFQueryBuilderClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FFQueryBuilderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new FORNITORIContext())
            {
                var filtri = new List<FFQueryBuilder.FilterItem>();
                //filtri.Add(new FilterItem()
                //{
                //    Field = "DataFineRda",
                //    Value = "2022/10/13"
                //});

                //filtri.Add(new FilterItem()
                //{
                //    Field = "CodiceRda",
                //    Value = "0000045235"
                //});

                //filtri.Add(new FilterItem()
                //{
                //    Field = "RegolaritaContributiva",
                //    Value = "True"
                //});

                //filtri.Add(new FilterItem()
                //{
                //    Field = "IdAlert",
                //    Value = "336d2b31-9453-41a2-a8f6-0657d8ae7446"
                //});

                filtri.Add(new FilterItem()
                {
                    Field = "InviatoA",
                    Value = "support",
                    Operator = CompareOperator.Contiene
                });

                var order = new OrderItem()
                {
                    Field = "CodiceRda",
                    TypeOfOrder = OrderType.Discendente
                };

                var q = ctx.FrnCodaEmails
                    .FilterBy(filtri)
                    .OrderByField(order)
                    ;

                var qs = q.ToQueryString();

                var res = q.ToList();
            }
        }
    }
}
