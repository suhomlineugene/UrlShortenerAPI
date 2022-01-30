using Microsoft.EntityFrameworkCore;
using UrlShortenerApi.Data.Entities;

namespace UrlShortenerApi.EntityFrameworkCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ShortLink> ShortLinks { get; set; }
    }
}