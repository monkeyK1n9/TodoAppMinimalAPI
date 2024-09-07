using MakeIt.Data;
using MakeIt.Dtos.TodoDtos;
using MakeIt.Endpoints.TodoEndpoints;

var builder = WebApplication.CreateBuilder(args);

// SERVICES
var connectionString = builder.Configuration.GetConnectionString("MakeIt");

builder.Services.AddSqlite<MakeItContext>(connectionString);


var app = builder.Build();

// get all todos
app.MapTodoEndpoints();

await app.MigrateDbAsync();

app.Run();
