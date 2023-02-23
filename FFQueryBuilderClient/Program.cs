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

                filtri.Add(new FilterItem()
                {
                    Field = "LivelloAutorizzazione",
                    Value = "1",
                    Operator = CompareOperator.Uguale
                });

                var order = new OrderItem()
                {
                    Field = "CodiceRda",
                    TypeOfOrder = OrderType.Discendente
                };

                var q = ctx.FrnUtentis
                    .FilterBy(filtri);
                    //.OrderByField(order);

                var qs = q.ToQueryString();

                var res = q.ToList();
            }
        }
    }
}
