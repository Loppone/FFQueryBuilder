using FFQueryBuilder;
using FFQueryBuilder.Helpers;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorsController : ControllerBase
    {
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(Dictionary<string, IEnumerable<CompareOperator>>), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult<Dictionary<string, IEnumerable<CompareOperator>>> Get()
        {
            return Ok(OperatorHelpers.OperatorsByType());
        }  
    }
}
