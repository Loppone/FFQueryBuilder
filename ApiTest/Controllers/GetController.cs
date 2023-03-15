using FFQueryBuilder;
using FFQueryBuilder.Context;
using FFQueryBuilder.Repository;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        private readonly ICreateFactory<DbOperation> _dbOperationFactory;

        public GetController(ICreateFactory<DbOperation> dbOperationFactory)
        {
            _dbOperationFactory = dbOperationFactory;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.NoContent, typeof(string), Description = "Nessun dato")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Post(string contextName, string entityName, Dictionary<string, object> filter)
        {
            var op = _dbOperationFactory.Create(contextName, entityName);
            var singleRow = op.FirstByFilters(filter);

            if (singleRow == null)
                return StatusCode(204, "Record non trovato!");

            return Ok(singleRow);
        }
    }
}

/*
 * SENZA MAP DINAMICO
 * 
{
  "lazyLoader": { },
  "userad": "mbertoli",
  "livelloAutorizzazione": 1,
  "nomecognome": "max",
  "visualizzareport": true
}
*/


/*
 * CON MAP DINAMICO
 * 
{
  "userad": "mbertoli",
  "livelloAutorizzazione": 1,
  "nomecognome": "max",
  "visualizzareport": true
}
*/