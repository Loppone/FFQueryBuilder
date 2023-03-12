using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Repository;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        private readonly IWriteableRepository _repository;

        public AddController(IWriteableRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Post(string db, string table, Dictionary<string,object> row)
        {
            var manager = new EntityManager(db, table);
            manager.CreateEntityInstance(row);

            _repository.Add(manager.Context, manager.Entity, manager.EntityValues);
            return Ok();
        }
    }
}
