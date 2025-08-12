using Staffing.Entities;
using Staffing.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staffing.Repositories.Interfaces;

namespace Staffing.Services.Implementations
{
    public class StaffingService : IStaffingService
    {
        private IStaffingRepo _repo;

        public StaffingService(IStaffingRepo repo)
        {
            _repo = repo;
        }
        public bool AddEmployee(Employee employee)
        {
            return _repo.AddEmployee(employee);
        }

        public bool DeleteEmployee(int id)
        {
            return _repo.DeleteEmployee(id);
        }

        public List<Employee> GetAll()
        {
            return _repo.GetAll();
        }

        public Employee GetById(int id)
        {
            return _repo.GetById(id);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _repo.UpdateEmployee(employee);
        }
    }
}
