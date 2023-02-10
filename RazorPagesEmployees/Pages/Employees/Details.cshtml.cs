using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEmployees.Models;
using RazorPagesEmployees.Service;

namespace RazorPagesEmployees.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public Employee Employee { get; private set; }
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;
        }

       

        public void OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);
        }
    }
}
