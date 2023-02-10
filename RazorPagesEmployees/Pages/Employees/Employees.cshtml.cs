using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEmployees.Models;
using RazorPagesEmployees.Service;

namespace RazorPagesEmployees.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
        private readonly IEmployeeRepository _db;
        public IEnumerable<Employee> Employees { get; set; }
        public EmployeesModel(IEmployeeRepository db)
        {
            _db= db;
        }
        public void OnGet()
        {
            Employees = _db.GetAllEmployees();
        }
    }
}
