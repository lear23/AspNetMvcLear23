using AspNetMvcLear23.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcLear23.Controllers
{
    public class AccountController : Controller
    {


        [Route("/details")]
        public IActionResult Details()
        {
            var viewModel = new AccountDetailsViewModel();

            return View(viewModel);


        }


        [HttpPost]
        public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
        {

            return RedirectToAction(nameof(Details), viewModel);

        }
    }
    
}
