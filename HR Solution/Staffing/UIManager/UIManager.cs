using Staffing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staffing.UIManager
{
    public class UIManager
    {

        public void ShowMenu()
        {
            Console.WriteLine("Select Menu");
            Console.WriteLine("1. Get Employee List");
            Console.WriteLine("2. Get Employee By Id");
            Console.WriteLine("3. Add Employee");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exist");

        }

        public int GetChoice()
        {
            Console.WriteLine("Enter your choice :");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public void ShowAll(List<Employee> employees)
        {
            Console.WriteLine("Employee List :");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"ID :{employee.Id},Name :{employee.Name},Position :{employee.Position}");
            }
        }
        
        public int AcceptedId()
        {
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());
            return id;
        }


        public void Show(Employee employee)
        {
            Console.WriteLine($"Id : {employee.Id}, Name: {employee.Name}, Position:{employee.Position}");
        }

        public Employee AcceptEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Details:");

            Console.WriteLine("Enter Employee Name :");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter Position :");
            employee.Position = Console.ReadLine();

            return employee;
        }


        public void ShowMessage(string operation, bool status)
        {
            if (status)
            {
                Console.WriteLine(operation + "Success");
            }
            else
            {
                Console.WriteLine(operation + "fail");
            }

        }

        public int DeleteId()
        {
            Console.WriteLine("Enter id for deletetion : ");
            int id = int.Parse(Console.ReadLine());
            return id;

        }

       
    }
}
