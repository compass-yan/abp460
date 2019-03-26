using Microsoft.AspNetCore.Antiforgery;
using myAbp.Controllers;

namespace myAbp.Web.Host.Controllers
{
    public class AntiForgeryController : myAbpControllerBase
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
