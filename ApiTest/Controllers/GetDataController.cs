using FFQueryBuilder;
using FFQueryBuilder.DataAccess;
using FFQueryBuilder.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDataController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //var res = GetOracleData();

            var res = GetSqlData();

            return Ok(res);
        }

        private dynamic? GetSqlData()
        {
            var pageDto = new Paging();
            pageDto.Filters = new List<FilterItem>()
                {
                    new FilterItem()
                    {
                        Field = "userad",
                        Value = "sa",
                        Operator = CompareOperator.Contiene
                    }
                };
            pageDto.CurrentPage = 1;
            pageDto.ItemPerPage = 5;

            IPaging data = new PagingQuery();
            return data.GetData("SqlServer", "FrnUtenti", pageDto);
        }

        private dynamic? GetOracleData()
        {
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
            return data.GetData("Oracle", "Woreq", pageDto);
        }
    }
}
