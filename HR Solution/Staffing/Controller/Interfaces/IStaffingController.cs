using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staffing.Entities;


namespace Staffing.Controller.Interfaces
{
    public interface IStaffingController
    {
        List<Employee> GetList();
        Employee GetById(int id);
        bool Post(Employee employee);
        bool Put(Employee employee);
        bool Remove(int id);
    }
}
