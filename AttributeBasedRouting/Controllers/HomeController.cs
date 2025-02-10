using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("home/about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("home/detail")]
        public IActionResult Detail()
        {
            return View();
        }
    }
}
