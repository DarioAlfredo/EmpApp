using EmpApp.Components.Models;

namespace EmpApp.Components.Services.Title
{
    public interface ITitleService
    {
        Task<IEnumerable<TitleDto>> GetTitlesAsync();
    }
}
