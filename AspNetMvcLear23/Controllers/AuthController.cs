using AspNetMvcLear23.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcLear23.Controllers;

public class AuthController : Controller
{
    #region SignUp


    [Route("/signup")]
    [HttpGet]
    public IActionResult SignUp()
    {

        var viewModel = new SignUpViewModel();

        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel model)
    {
        if(!ModelState.IsValid) 
              return View(model);

        return RedirectToAction("Signin", "Auth");
    }
    #endregion


    #region



    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {

        var viewModel = new SignInViewModel();

        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        return RedirectToAction("Details", "Auth");
    }

    #endregion
}
