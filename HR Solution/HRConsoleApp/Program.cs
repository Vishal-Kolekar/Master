using Google.Protobuf.WellKnownTypes;
using Staffing.Controller.Implementations;
using Staffing.Entities;
using Staffing.Repositories.Implementations;
using Staffing.Repositories.Interfaces;
using Staffing.Services.Implementations;
using Staffing.Services.Interfaces;
using Staffing.Controller.Interfaces;
using Staffing.UIManager;



IStaffingRepo repo = new StaffingRepo();
   IStaffingService service = new StaffingService(repo);
   IStaffingController controller = new StaffingController(service);

UIManager mgr = new UIManager();

mgr.ShowMenu();

while (true)
{
    int choice = mgr.GetChoice();
    switch (choice)
    {
        case 1:
            {
                List<Employee> employees = controller.GetList();
                mgr.ShowAll(employees);
                break;
            }
          

        case 2:
            {
                int id = mgr.AcceptedId();
                Employee employee = controller.GetById(id);

                if(employee != null)
                {
                    mgr.Show(employee);
                }
               
                break;
            }
          

        case 3:
            {
                Employee employee = mgr.AcceptEmployee();
                controller.Post(employee);

            }
            break;

        case 4:
            {
                int id = mgr.AcceptedId();
                Employee existingEmployee = controller.GetById(id);

                if (existingEmployee == null)
                {
                    mgr.ShowMessage("Employee not found", false); // Employee not found
                    break;
                }

                Employee updatedEmployee = mgr.AcceptEmployee();
                updatedEmployee.Id = existingEmployee.Id; // Keep the same ID

                bool status = controller.Put(updatedEmployee);
                mgr.ShowMessage("Update", status);
            }
            break;

        case 5:
            {
                int id = mgr.DeleteId();
                controller.Remove(id);

            }
            break;
        case 6:
            {
                return 0;
                break;
            }
    }


}



    ///////////////////// Get Employees

   //List<Employee> employees = controller.GetList();

   //foreach (var employee in employees)
   // {
   //  Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Position :{employee.Position}");
   // }


///////////////////// GetById Employee
//Console.WriteLine("Search By Employee Id");

//int id = int.Parse(Console.ReadLine());

//Employee emplo = controller.GetById(id);

//Console.WriteLine($"Id : {emplo.Id} ,Name : {emplo.Name}, Position :{emplo.Position}");





///////////////////// ADD Employee
//Console.WriteLine("Add Employee Details");

// Employee empl = new Employee();

// Console.WriteLine("Employee Name");
// empl.Name = Console.ReadLine();
// Console.WriteLine("Employee Position");
// empl.Position = Console.ReadLine();

// bool status = controller.Post(empl);


///////////////////// Update Employee
//Console.WriteLine("Update Employee id");
//Employee employee1 = new Employee();

//int ids = int.Parse(Console.ReadLine());

//Employee foundEmployee = controller.GetById(ids);

//Console.WriteLine($"Id : {foundEmployee.Id} ,Name : {foundEmployee.Name}, Position :{foundEmployee.Position}");

//Console.WriteLine("Employee Name");
//employee1.Name =Console.ReadLine();

//Console.WriteLine("Employee Position");
//employee1.Position = Console.ReadLine();

//if (foundEmployee != null)
//{
//      foundEmployee.Name = employee1.Name;
//      foundEmployee.Position= employee1.Position;
//}

//bool status = controller.Put(foundEmployee);

//if (status)
//{
//    Console.WriteLine("Employee updated successfully");
//}




/////////////Delete EMPLOYEE

//Console.WriteLine("Delete Employee");

//int idss = int.Parse(Console.ReadLine());


//bool status1 = controller.Remove(idss);

//if (status1)
//{
//    Console.WriteLine("Employee deleted successfully");
//}












