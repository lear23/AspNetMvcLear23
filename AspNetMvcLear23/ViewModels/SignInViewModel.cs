using AspNetMvcLear23.Models;

namespace AspNetMvcLear23.ViewModels
{
    public class SignInViewModel
    {
        public string Title { get; set; } = "Sign In";
        public SignInModel Model { get; set; } = new SignInModel();

    }
}
