using FF3DContexts.OracleModels;
using FF3DContexts.SqlModels;
using FFQueryBuilder.AutoMapperProfiles;
using FFQueryBuilder.Context;
using FFQueryBuilder.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FORNITORIContext>(opt =>
{
    opt.UseSqlServer("Data Source=RKPSQL01PRD.intra.manutencoop.it\\PRD;Initial Catalog=FORNITORI;Persist Security Info=True;connect timeout=3600;User ID=svc_fornitori;Password=srdfHJ45/",
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

builder.Services.AddSingleton<DbContextFactory>(x =>
    {
        return ActivatorUtilities.CreateInstance<DbContextFactory>(x);
    }
);


DbContextFactory.Instance.AddDbContext("SqlServer", new FORNITORIContext());
DbContextFactory.Instance.AddDbContext("Oracle", new ModelContext());

builder.Services.AddAutoMapper(typeof(ContextProfile).Assembly);


builder.Services.AddTransient<IWriteableRepository, WriteRepository>();

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
