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
    public class GetController : ControllerBase
    {
        private readonly IDbContextManager _contextManager;
        private readonly DbContextFactory _contextFactory;
        private readonly IReadableRepository _repository;

        public GetController(IDbContextManager contextManager, DbContextFactory contextFactory, IReadableRepository repository)
        {
            _contextManager = contextManager;
            _contextFactory = contextFactory;
            _repository = repository;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.NoContent, typeof(string), Description = "Nessun dato")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Post(string contextName, string entityName, Dictionary<string, object> filter)
        {
            var manager = new EntityManager(_contextManager, _contextFactory, contextName, entityName);

            _repository.Context = manager.Context;
            _repository.Entity = manager.Entity;
            _repository.ContextName = contextName;
            _repository.EntityName = entityName;

            var r = _repository.First(filter);

            if (r != null)
            {
                var dynMap = new DynamicMapper(_contextManager);
                var map = dynMap.Map(r, manager.Context, manager.Entity, contextName, entityName);
                return Ok(map);
            }

            return StatusCode(204, "Record non trovato!");
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