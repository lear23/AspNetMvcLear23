using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Infrastructure.Helpers;

namespace AspNetMvcLear23.Models
{
    public class SignUpModel
    {

        [DisplayName("First name")]
        [Required(ErrorMessage = "Invalid first name")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Last name")]
        [Required(ErrorMessage = "Invalid last name")]
        public string LastName { get; set; } = null!;

        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]       
        public string Email { get; set; } = null!;

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must be at least 8 characters long, and include at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; } = null!;


        [DisplayName("Confirm password")]
        [Required(ErrorMessage = "Must confirm password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; } = null!;

        [DisplayName("I agree to the Terms & Conditions")]
        [CheckBoxRequired(ErrorMessage = "You must agree to the terms & conditions")]
        public bool Terms { get; set; }

    }
}
