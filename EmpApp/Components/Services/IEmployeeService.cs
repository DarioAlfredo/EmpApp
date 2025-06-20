using EmpApp.Components.Models;

namespace EmpApp.Components.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
        Task<EmployeeDto?> GetEmployeeByIdAsync(int id);
        Task UpdateEmployeeAsync(EmployeeDto employee);
        Task CreateEmployeeAsync(EmployeeDto employee);
        Task DeleteEmployeeAsync(int employeeId);
    }
}
