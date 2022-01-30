using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UrlShortenerApi.Data.Entities
{
    [Table("ShortLinks")]
    public class ShortLink
    {
        public int Id { get; set; }

        public string OriginalUrl { get; set; }
        
        public string ShortCode { get; set; }
        
        public string ShortUrl { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}