using Microsoft.AspNetCore.Mvc;
using Staffing.Controller.Implementations;
using Staffing.Controller.Interfaces;
using Staffing.Entities;
using Staffing.Repositories.Implementations;
using Staffing.Repositories.Interfaces;
using Staffing.Services.Implementations;
using Staffing.Services.Interfaces;

IStaffingRepo repo = new StaffingRepo();
IStaffingService service = new StaffingService(repo);
IStaffingController controller = new StaffingController(service);



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();


app.MapGet("/get", () =>
{
    List<Employee> employees = controller.GetList();
    return employees;
});

app.MapGet("/getId/{id}", (int id) =>
{

    Employee employee = controller.GetById(id);
    return employee;
});

//app.MapPost("/postData/", (Employee employee) =>
//{
//    bool status;
//    status=controller.Post(employee);
//    return status;

//});

app.MapPost("/postData", ([FromBody] Employee employee) =>
{
    bool status = controller.Post(employee);
    return Results.Ok(status);
});

app.MapPut("/putData", ([FromBody] Employee employee) =>
{
    bool status = controller.Put(employee);
    return status;

});

app.MapDelete("/delete/{id}", (int id) =>
{

    controller.Remove(id);
    return true;
});

app.Run();

