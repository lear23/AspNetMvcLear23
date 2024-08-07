using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcLear23.Controllers;

public class AuthController : Controller
{

    [Route("/signup")]
    public IActionResult SignUp()
    {
        return View();
    }

    


}
