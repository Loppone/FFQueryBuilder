using FFQueryBuilder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FFQueryBuilder.DataAccess
{
    public interface IPaging
    {
        dynamic GetData(DbContext db, List<Type> tipi, string tabella, Paging page);
    }
}
