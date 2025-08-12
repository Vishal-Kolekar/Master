using Staffing.Controller.Interfaces;
using Staffing.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staffing.Entities;


namespace Staffing.Controller.Implementations
{
    public class StaffingController : IStaffingController
    {
        private IStaffingService _service;

        public StaffingController(IStaffingService service)
        {
            _service = service;
        }

       public List<Employee> GetList()
        {
            return _service.GetAll();
        }

        public Employee GetById(int id)
        {
            return _service.GetById(id);
        }

        public bool Post(Employee employee)
        {
            return _service.AddEmployee(employee);
        }

        public bool Put(Employee employee)
        {
            return _service.UpdateEmployee(employee);
        }

        public bool Remove(int id)
        {
            return _service.DeleteEmployee(id);
        }

     
    }
}
