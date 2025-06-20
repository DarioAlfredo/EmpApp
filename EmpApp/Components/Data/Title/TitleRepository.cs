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
}