using CRUD.Areas.Employees.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Areas.Employees.Models
{
    public class VmEmployee
    {
        public int Id { get; set; }
        public string employeeCode { get; set; }
        public string employeeName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public IFormFile Image { get; set; }
        public IList<Employee> employees { get; set; }
    }
}
