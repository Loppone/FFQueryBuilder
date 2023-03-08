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
            var res = data.GetData("Oracle", "Woreq", pageDto);

            return Ok(res);
        }
    }
}
