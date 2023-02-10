using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesEmployees.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? PhotoPath { get; set; }
        public Dept? Department { get; set; }

        public Employee(int id, string name, string email, string? photoPath, Dept? department)
        {
            Id = id;
            Name = name;
            Email = email;
            PhotoPath = photoPath;
            Department = department;
        }

        public Employee(int id, string name, string email, Dept? department)
        {
            Id = id;
            Name = name;
            Email = email;
            Department = department;
        }
    }
}
