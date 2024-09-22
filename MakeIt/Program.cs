using MakeIt.Data;
using MakeIt.Endpoints.TodoEndpoints;

var builder = WebApplication.CreateBuilder(args);

// SERVICES
var connectionString = builder.Configuration.GetConnectionString("MakeIt");

builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlite<MakeItContext>(connectionString);
builder.Services.AddCors(opt => opt.AddDefaultPolicy(x =>
    x.AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin()));

var app = builder.Build();

app.UseSwagger();

app.UseCors();

app.MapTodoEndpoints();

app.MapRazorPages();

await app.MigrateDbAsync();

app.Run();
