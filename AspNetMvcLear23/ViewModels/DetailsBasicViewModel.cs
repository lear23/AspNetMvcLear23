using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspNetMvcLear23.ViewModels
{
    public class DetailsBasicViewModel
    {
        [Display(Name = "First name", Prompt = "Enter your first name")]
        [Required(ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last name", Prompt = "Enter your Last name")]
        [Required(ErrorMessage = "Invalid last name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Email Address", Prompt = "Enter your email address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [Display(Name="Phone", Prompt = "Enter your phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Invalid Phone")]
        public string? Phone { get; set; }

        [Display(Name = "Bio", Prompt = "Add a short bio...")]
        [DataType(DataType.MultilineText)]
        public string? Bio { get; set; } 
    }
}
