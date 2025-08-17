using Staffing.Repository.Implementation;
using Staffing.Repository.Interface;
using Staffing.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductService, ProductService>();
    

var app = builder.Build();

app.MapControllers();

app.Run();
