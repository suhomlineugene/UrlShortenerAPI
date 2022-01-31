using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using shortid;
using UrlShortenerApi.Data.Dto;
using UrlShortenerApi.Data.Entities;
using UrlShortenerApi.EntityFrameworkCore;
using UrlShortenerApi.Infrastructure.Interfaces;

namespace UrlShortenerApi.Infrastructure.AppServices
{
    public class ShortLinkAppService : IShortLinkAppService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ShortLinkAppService> _logger;
        private const string ServiceUrl = "http://localhost:5002";

        public ShortLinkAppService(ApplicationDbContext context, ILogger<ShortLinkAppService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ShortLinkDto> GenerateShortUrl(string longUrl)
        {
            var shortenedUrlCollection = await GetShortLinks();

            var shortenedUrl = shortenedUrlCollection
                .FirstOrDefault(x => x.OriginalUrl == longUrl);

            if (shortenedUrl == null)
            {
                var shortCode = ShortId.Generate(length: 8);
                shortenedUrl = new ShortLinkDto()
                {
                    CreatedAt = DateTime.UtcNow,
                    OriginalUrl = longUrl,
                    ShortCode = shortCode,
                    ShortUrl = $"{ServiceUrl}/{shortCode}"
                };
                // add to database
                await InsertShortUrl(shortenedUrl);
                return shortenedUrl;
            }

            return shortenedUrl;
        }

        public async Task<ShortLinkDto> Redirect(string input)
        {
            var shortenedUrlCollection = await GetShortLinks();

            var shortenedUrl = shortenedUrlCollection
                .FirstOrDefault(x => x.ShortCode == input);

            return shortenedUrl;
        }

        public async Task<List<ShortLinkDto>> GetShortLinks()
        {
            var shortLinksList = await _context.ShortLinks.ProjectTo<ShortLinkDto>().ToListAsync();
            return shortLinksList;
        }

        private async Task InsertShortUrl(ShortLinkDto input)
        {
            var shortUrl = Mapper.Map<ShortLink>(input);
            await _context.ShortLinks.AddAsync(shortUrl);
            await _context.SaveChangesAsync();
        }
    }
}