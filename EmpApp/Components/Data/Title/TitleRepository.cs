using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using EmpApp.Components.Models;

namespace EmpApp.Components.Services.Title;
public class TitleRepository : ITitleRepository
{
    private readonly IConfiguration _config;
    public TitleRepository(IConfiguration config) => _config = config;

    public async Task<IEnumerable<TitleDto>> GetTitlesAsync()
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        return await conn.QueryAsync<TitleDto>("GetTitles", commandType: CommandType.StoredProcedure);
    }

    public async Task<TitleDto?> GetTitleByIdAsync(int id)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        return await conn.QueryFirstOrDefaultAsync<TitleDto>(
            "GetTitleById", new { EmployeeTitleID = id }, commandType: CommandType.StoredProcedure);
    }

    public async Task AddTitleAsync(TitleDto title)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        await conn.ExecuteAsync(
            "AddTitle",
            new { title.Descr },
            commandType: CommandType.StoredProcedure);
    }

    public async Task UpdateTitleAsync(TitleDto title)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        await conn.ExecuteAsync(
            "UpdateTitle",
            new { title.EmployeeTitleID, title.Descr },
            commandType: CommandType.StoredProcedure);
    }

    public async Task DeleteTitleAsync(int id)
    {
        using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        await conn.ExecuteAsync(
            "DeleteTitle",
            new { EmployeeTitleID = id },
            commandType: CommandType.StoredProcedure);
    }
}