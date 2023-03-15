using FFQueryBuilder;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        private readonly ICreateFactory<DbOperation> _dbOperationFactory;

        public DeleteController(ICreateFactory<DbOperation> dbOperationFactory)
        {
            _dbOperationFactory = dbOperationFactory;
        }

        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Delete(string contextName, string entityName, Dictionary<string, object> id)
        {
            var op = _dbOperationFactory.Create(contextName, entityName);

            try
            {
                var deletedEntity = op.Delete(id);
                return Ok(deletedEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
