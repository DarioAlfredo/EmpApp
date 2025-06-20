using EmpApp.Components.Models;

namespace EmpApp.Components.Services
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
        Task<EmployeeDto?> GetEmployeeByIdAsync(int id);
        Task UpdateEmployeeAsync(EmployeeDto employee);
    }
}
