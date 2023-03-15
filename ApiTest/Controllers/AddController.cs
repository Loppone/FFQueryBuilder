using FFQueryBuilder;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        private readonly ICreateFactory<DbOperation> _dbOperationFactory;

        public AddController(ICreateFactory<DbOperation> dbOperationFactory)
        {
            _dbOperationFactory = dbOperationFactory;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Post(string db, string table, Dictionary<string, object> row)
        {
            var op = _dbOperationFactory.Create(db, table);

            try
            {
                return Ok(op.Add(row));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
