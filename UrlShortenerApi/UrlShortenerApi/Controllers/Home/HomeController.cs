using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlShortenerApi.Infrastructure.Interfaces;

namespace UrlShortenerApi.Controllers.Home
{
    public class HomeController : Controller
    {
        private readonly IShortLinkAppService _shortLinkAppService;

        public HomeController(IShortLinkAppService shortLinkAppService)
        {
            _shortLinkAppService = shortLinkAppService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index(string u)
        {
            var shortLink = await _shortLinkAppService.Redirect(u);

            if (shortLink == null)
            {
                var shortLinks = await _shortLinkAppService.GetShortLinks();
               
                return View(shortLinks);
            }

            return Redirect(shortLink.OriginalUrl);
        }


        [HttpPost]
        public async Task<IActionResult> ShortenUrl(string longUrl)
        {
            var shortenedUrl = await _shortLinkAppService.GenerateShortUrl(longUrl);

            return View(shortenedUrl);
        }
    }
}