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

        public async Task<EmployeeDto?> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task UpdateEmployeeAsync(EmployeeDto employee)
        {
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }

        public async Task CreateEmployeeAsync(EmployeeDto employee)
        {
            await _employeeRepository.CreateEmployeeAsync(employee);
        }
    }
}