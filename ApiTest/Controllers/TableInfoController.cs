﻿using FFQueryBuilder;
using FFQueryBuilder.Models.Contexts;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableInfoController : ControllerBase
    {
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(IEnumerable<ModelInfo>), Description = "Successfull operation")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(string), Description = "Internal Server Error")]
        public ActionResult<IEnumerable<ConfiguredContexts>> Get(string db, string table)
        {
            return Ok(DbContextHelper.EntityInformation(db, table));
        }
    }
}