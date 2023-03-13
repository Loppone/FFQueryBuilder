using FFQueryBuilder;
using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;
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
        private readonly DbContextFactory _contextFactory;
        private readonly IDbContextManager _dbContextManager;
        private readonly IWriteableRepository _repository;

        public AddController(DbContextFactory contextFactory, IDbContextManager dbContextManager, IWriteableRepository repository)
        {
            _contextFactory = contextFactory;
            _dbContextManager = dbContextManager;
            _repository = repository;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Post(string db, string table, Dictionary<string,object> row)
        {
            // TODO
            // Invertire eventualmente la dipendenza
            var manager = new EntityManager(_dbContextManager, _contextFactory, db, table);
            
            manager.CreateEntityInstance(row);

            _repository.Context = manager.Context;
            _repository.Entity = manager.Entity;
            
            return Ok(_repository.Add(manager.EntityValues));
        }
    }
}
