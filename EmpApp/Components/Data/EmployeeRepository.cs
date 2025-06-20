using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using EmpApp.Components.Models;
using EmpApp.Components.Services;

namespace EmpApp.Components.Services;
public class EmployeeRepository : IEmployeeRepository
{
    private readonly IConfiguration _config;
    public EmployeeRepository(IConfiguration config) => _config = config;

    public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        return await conn.QueryAsync<EmployeeDto>("GetEmployeesWithTitles", commandType: CommandType.StoredProcedure);
    }

    public async Task<EmployeeDto?> GetEmployeeByIdAsync(int id)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        var result = await conn.QueryFirstOrDefaultAsync<EmployeeDto>(
            "GetEmployeeById", new { EmployeeID = id }, commandType: CommandType.StoredProcedure);
        return result;
    }

    public async Task UpdateEmployeeAsync(EmployeeDto employee)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        await conn.ExecuteAsync(
            "UpdateEmployee",
            new
            {
                employee.EmployeeID,
                employee.FirstName,
                employee.LastName,
                employee.DOB,
                employee.IsActive,
                employee.EmployeeTitleID
            },
            commandType: CommandType.StoredProcedure);
    }

    public async Task CreateEmployeeAsync(EmployeeDto employee)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        await conn.ExecuteAsync(
            "CreateEmployee",
            new
            {
                employee.FirstName,
                employee.LastName,
                employee.DOB,
                employee.IsActive,
                employee.EmployeeTitleID
            },
            commandType: CommandType.StoredProcedure);
    }

    public async Task DeleteEmployeeAsync(int employeeId)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        await conn.ExecuteAsync(
            "DeleteEmployee",
            new { EmployeeID = employeeId },
            commandType: CommandType.StoredProcedure);
    }
}