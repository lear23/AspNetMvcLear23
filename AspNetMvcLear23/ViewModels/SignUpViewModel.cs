using AspNetMvcLear23.Models;

namespace AspNetMvcLear23.ViewModels
{
    public class SignUpViewModel
    {
        public string Title { get; set; } = "Sign Up";
        public SignUpModel SignUpModel { get; set; } = new SignUpModel();
    }
}
