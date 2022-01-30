using System;
using Microsoft.AspNetCore.WebUtilities;

namespace UrlShortenerApi.Data.Dto
{
    public class ShortLinkDto
    {
        public int Id { get; set; }

        public string OriginalUrl { get; set; }
        
        public string ShortCode { get; set; }
        
        public string ShortUrl { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}