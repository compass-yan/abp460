using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using myAbp.Controllers;

namespace myAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : myAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
