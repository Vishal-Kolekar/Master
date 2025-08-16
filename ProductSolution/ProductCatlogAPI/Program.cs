using Staffing.Repository.Implementation;
using Staffing.Repository.Interface;
using Staffing.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();
