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
    }
}