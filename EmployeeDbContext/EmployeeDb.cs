using CRUD.Areas.Employees.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.EmployeeDbContext
{
    public class EmployeeDb:DbContext
    {
        public EmployeeDb()
        {

        }
        public EmployeeDb(DbContextOptions<EmployeeDb> option) : base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
