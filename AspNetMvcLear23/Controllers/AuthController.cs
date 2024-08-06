using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcLear23.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
