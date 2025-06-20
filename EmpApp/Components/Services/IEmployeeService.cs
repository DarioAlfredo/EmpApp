using EmpApp.Components.Models;

namespace EmpApp.Components.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
    }
}
