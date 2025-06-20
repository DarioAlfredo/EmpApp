using EmpApp.Components.Models;

namespace EmpApp.Components.Services.Title
{
    public class TitleService : ITitleService
    {
        private readonly ITitleRepository _titleRepository;
        public TitleService(ITitleRepository titleRepository)
        {
            _titleRepository = titleRepository;
        }

        public async Task<IEnumerable<TitleDto>> GetTitlesAsync()
        {
            return await _titleRepository.GetTitlesAsync();
        }

        public async Task<TitleDto?> GetTitleByIdAsync(int id)
        {
            return await _titleRepository.GetTitleByIdAsync(id);
        }

        public async Task AddTitleAsync(TitleDto title)
        {
            await _titleRepository.AddTitleAsync(title);
        }

        public async Task UpdateTitleAsync(TitleDto title)
        {
            await _titleRepository.UpdateTitleAsync(title);
        }

        public async Task DeleteTitleAsync(int id)
        {
            await _titleRepository.DeleteTitleAsync(id);
        }
    }
}