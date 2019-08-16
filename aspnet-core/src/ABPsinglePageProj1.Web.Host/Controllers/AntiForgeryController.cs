using Microsoft.AspNetCore.Antiforgery;
using ABPsinglePageProj1.Controllers;

namespace ABPsinglePageProj1.Web.Host.Controllers
{
    public class AntiForgeryController : ABPsinglePageProj1ControllerBase
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
