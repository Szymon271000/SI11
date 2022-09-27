using LearningDiary.Config;
using LearningDiary.Context;
using LearningDiary.Repository;
using Materials.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSwaggerGen();

var config = new ServerConfig();
builder.Configuration.Bind(config);
builder.Services.AddSingleton<IDbClient, DbClient>();
var materialContext = new MaterialContext(config.MongoDB);
var repo = new MaterialRepository(materialContext);
builder.Services.AddSingleton<IMaterialRepository>(repo);

builder.Services.Configure<MaterialDbConfig>(builder.Configuration);
builder.Services.AddScoped<IMaterialServices, MaterialsServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
