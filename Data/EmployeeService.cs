using DxBlazorCRUD.Context;
using Microsoft.EntityFrameworkCore;

namespace DxBlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _applicationDbcontext;
        public EmployeeService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbcontext = applicationDbContext;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _applicationDbcontext.Employees.ToListAsync();
        }

        public async Task<bool> AddNewEmployee(Employee employee)
        {
            await _applicationDbcontext.Employees.AddAsync(employee);
            await _applicationDbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            Employee employee = await _applicationDbcontext.Employees.Where(x => x.Id == id).FirstOrDefaultAsync();
            return employee;
        }

        public async Task<bool> UpdateEmployeeDetails(Employee employee)
        {
            _applicationDbcontext.Employees.Update(employee);
            await _applicationDbcontext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteEmployee(Employee employee)
        {
            _applicationDbcontext.Employees.Remove(employee);
            await _applicationDbcontext.SaveChangesAsync();

            return true;
        }
    }
}
