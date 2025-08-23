using ProductCatlogAPI.Repository.Implementation;
using ProductCatlogAPI.Repository.Interface;
using ProductCatlogAPI.Service.Implementation;
using ProductCatlogAPI.Service.Interface;
using Staffing.Repository.Implementation;
using Staffing.Repository.Interface;
using Staffing.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<ICategoryService, CategoryService>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontEnd",
        policy => policy.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());

});
    

var app = builder.Build();

app.UseCors("AllowFrontEnd");

app.MapControllers();

app.Run();
