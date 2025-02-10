using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    //we can also implement Attribute based routing using Token
    [Route("[controller]/[action]/[id?]")]
    public class BookingController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }
        public IActionResult Confirmation()
        {
            return View();
        }
        public IActionResult totalPrice()
        {
            return View();
        }
        //public IActionResult Geting(int id)
        //{
        //    return View(id);
        //}
    }
}
