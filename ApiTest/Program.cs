using FF3DContexts.OracleModels;
using FF3DContexts.SqlModels;
using FFQueryBuilder;
using FFQueryBuilder.AutoMapperProfiles;
using FFQueryBuilder.BusinessLogic;
using FFQueryBuilder.Context;
using FFQueryBuilder.DataAccess;
using FFQueryBuilder.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FORNITORIContext>(opt =>
{
    opt.UseSqlServer("Data Source=RKPSQL01DEV.intra.manutencoop.tst\\DEV;Initial Catalog=FORNITORI;Persist Security Info=True;User ID=svc_fornitori;Password=espfLO77!",
        sqlOption => sqlOption.CommandTimeout(900));

    opt.UseLazyLoadingProxies();
});

builder.Services.AddDbContext<ModelContext>(opt =>
{
    opt
        .UseOracle("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=ora11quality.intra.manutencoop.it)(PORT=1521))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME = MP2T)));USER ID=MP2; Password=MP2;",
            x => x.UseOracleSQLCompatibility("11")
        );
});

//builder.Services.AddScoped<DbContextFactory>(x =>
//    {
//        return ActivatorUtilities.CreateInstance<DbContextFactory>(x);
//    }
//);

builder.Services.AddScoped<DbContextFactory>();
builder.Services.AddScoped<IDbContextManager, DbContextManager>();
builder.Services.AddScoped<IPaging, PagingQuery>();

builder.Services.AddAutoMapper(typeof(ContextProfile).Assembly);

builder.Services.AddTransient<IWriteableRepository, WriteRepository>();
builder.Services.AddTransient<IReadableRepository, ReadRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
