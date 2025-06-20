using EmpApp.Components.Models;

namespace EmpApp.Components.Services.Title
{
    public interface ITitleRepository
    {
        Task<IEnumerable<TitleDto>> GetTitlesAsync();
        Task<TitleDto?> GetTitleByIdAsync(int id);
        Task AddTitleAsync(TitleDto title);
        Task UpdateTitleAsync(TitleDto title);
        Task DeleteTitleAsync(int id);
    }
}
