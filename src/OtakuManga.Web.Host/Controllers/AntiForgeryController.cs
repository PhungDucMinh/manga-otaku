using Microsoft.AspNetCore.Antiforgery;
using OtakuManga.Controllers;

namespace OtakuManga.Web.Host.Controllers
{
    public class AntiForgeryController : OtakuMangaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
