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


    #region SignIn



    [Route("/signin")]
    [HttpGet]
    public IActionResult SignIn()
    {

        var viewModel = new SignInViewModel();

        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewmodel)
    {
        

        if (!ModelState.IsValid)
        {
         
            return View(viewmodel);
        }

        viewmodel.ErrorMessage = "Invalid Email or password";

        return RedirectToAction("Details", "Auth");
    }

    #endregion
}
