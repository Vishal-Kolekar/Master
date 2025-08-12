using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staffing.Entities;

namespace Staffing.Repositories.Interfaces
{
    public interface IStaffingRepo
    {
         List<Employee> GetAll();
         Employee GetById(int id);
         bool AddEmployee(Employee employee);
         bool UpdateEmployee(Employee employee);
         bool DeleteEmployee(int id);

    }
}
