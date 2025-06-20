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
}