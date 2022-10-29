using CRUD.Areas.Employees.Data;
using CRUD.EmployeeDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Repository
{
    public class EmployeeRepository
    {
        private readonly EmployeeDb _ctx = null;
        public EmployeeRepository(EmployeeDb ctx)
        {
            _ctx = ctx;
        }
        public async Task<List<Employee>> GetEmployee()
        {
            return await _ctx.Employees.ToListAsync();
        }
        public async Task<int> SaveEmployee(Employee model)
        {
            if (model.Id != 0)
            {
                _ctx.Employees.Update(model);
            }
            else
            {
                _ctx.Employees.Add(model);
            }
            await _ctx.SaveChangesAsync();
            return model.Id;
        }
        public async Task<int> ToDelete(int id)
        {
            _ctx.Employees.Remove(_ctx.Employees.Find(id));
            return await _ctx.SaveChangesAsync();
        }
    }
}
