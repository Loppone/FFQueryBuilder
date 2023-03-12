using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;
using FFQueryBuilder.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        private readonly DbContextFactory _contextFactory;
        private readonly IWriteableRepository _repository;

        public AddController(DbContextFactory contextFactory, IWriteableRepository repository)
        {
            _contextFactory = contextFactory;
            _repository = repository;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(object), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult Post(string db, string table, Dictionary<string,object> row)
        {
            var manager = new EntityManager(_contextFactory, db, table);
            manager.CreateEntityInstance(row);

            _repository.Add(manager.Context, manager.Entity, manager.EntityValues);
            return Ok();
        }
    }
}
