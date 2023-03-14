using FFQueryBuilder;
using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;
using FFQueryBuilder.DynamicMapper;
using FFQueryBuilder.Repository;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteController : ControllerBase
    {
        private readonly DbContextFactory _contextFactory;
        private readonly IDbContextManager _dbContextManager;
        private readonly IWriteableRepository _repository;

        public DeleteController(DbContextFactory contextFactory, IDbContextManager dbContextManager, IWriteableRepository repository)
        {
            _contextFactory = contextFactory;
            _dbContextManager = dbContextManager;
            _repository = repository;
        }

        [HttpDelete]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Delete(string contextName, string entityName, object id)
        {
            var manager = new EntityManager(_dbContextManager, _contextFactory, contextName, entityName);

            _repository.Context = manager.Context;
            _repository.Entity = manager.Entity;
            _repository.ContextName = contextName;
            _repository.EntityName = entityName;

            var deletedEntity = _repository.Delete(id);

            if (deletedEntity == null)
                return StatusCode(400, "Impossibile Cancellare");

            var dynMap = new DynamicMapper(_dbContextManager);
            var map = dynMap.Map(deletedEntity, manager.Context, manager.Entity, contextName, entityName);

            return Ok(map);
        }
    }
}
