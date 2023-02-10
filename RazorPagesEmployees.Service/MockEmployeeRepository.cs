using RazorPagesEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesEmployees.Service
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(0,"Sergey","Sergey@example.com","avatar2.png",Dept.HR),
                new Employee(1,"Idol","Idol@example.com","avatar.png",Dept.IT),
                new Employee(2,"Roman","Roman@example.com","avatar4.png",Dept.IT),
                new Employee(3,"Dmitry","Dmitry@example.com","avatar5.png",Dept.Payroll),
                new Employee(4,"Nikita","Nikita@example.com","avatar3.png",Dept.HR),
                new Employee(5,"Danya","Danya@example.com",Dept.IT)
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
