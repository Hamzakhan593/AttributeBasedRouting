using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    // attribute based can also be implemented on the controller
    [Route("Customer")]
    public class CustomerController : Controller
    {
        [Route("")]
        [Route("Customers")]
        
        public IActionResult Customers()
        {
            return View();
        }
        [Route("booking")]
        public IActionResult Booking() 
        {
            return View();
        }
        [Route("delete")]
        public IActionResult Delete() 
        {
            return View();
        }
    }
}
