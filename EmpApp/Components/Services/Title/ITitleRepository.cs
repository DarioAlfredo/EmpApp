using EmpApp.Components.Models;

namespace EmpApp.Components.Services.Title
{
    public interface ITitleRepository
    {
        Task<IEnumerable<TitleDto>> GetTitlesAsync();
    }
}
