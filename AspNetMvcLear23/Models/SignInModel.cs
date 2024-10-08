﻿using System.ComponentModel.DataAnnotations;


namespace AspNetMvcLear23.Models
{
    public class SignInModel
    {
        [Display(Name = "Email address", Prompt = "Enter your email address", Order = 0)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email address is required")]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password", Prompt = "Enter your password", Order = 1)]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;


        [Display(Name = "Remember me", Order = 2)]
        public bool RememberMe { get; set; }
    }
}
