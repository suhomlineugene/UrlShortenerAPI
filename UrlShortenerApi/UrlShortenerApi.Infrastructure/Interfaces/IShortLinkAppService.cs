using System.Collections.Generic;
using System.Threading.Tasks;
using UrlShortenerApi.Data.Dto;

namespace UrlShortenerApi.Infrastructure.Interfaces
{
    public interface IShortLinkAppService
    {
        Task<ShortLinkDto?> GenerateShortUrl(string longUrl);

        Task<ShortLinkDto> Redirect(string input);

        Task<List<ShortLinkDto>> GetShortLinks();
    }
}