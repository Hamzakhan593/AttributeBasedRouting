using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    public class UserController : Controller
    {
        [Route("user/index/{id}")]
        public IActionResult Index(int id)
        {
            return View(id);
        }
    }
}
