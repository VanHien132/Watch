using Microsoft.AspNetCore.Mvc;

namespace Fontend.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
