using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcLear23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }


        public IActionResult Error(int statusCode) => View();
    }
}
