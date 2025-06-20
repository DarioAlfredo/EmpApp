using EmpApp.Components.Models;
using EmpApp.Components.Services;

namespace EmpApp.Components.Data
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }
    }
}