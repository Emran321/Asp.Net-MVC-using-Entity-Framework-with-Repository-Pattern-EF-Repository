using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Areas.Employees.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string employeeCode { get; set; }
        public string employeeName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Image { get; set; }
    }
}
