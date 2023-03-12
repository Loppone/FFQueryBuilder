using FFQueryBuilder;
using FFQueryBuilder.Models.Contexts;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTablesController : ControllerBase
    {
        private readonly IDbContextManager _contextManager;

        public GetTablesController(IDbContextManager contextManager)
        {
            _contextManager = contextManager;
        }

        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(IEnumerable<ConfiguredContexts>), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult<IEnumerable<ConfiguredContexts>> Get()
        {
            return Ok(_contextManager.GetConfiguredContexts());
        }  
    }
}
