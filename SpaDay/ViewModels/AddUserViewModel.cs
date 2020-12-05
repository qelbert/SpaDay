using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Please enter a name that is 5-15 characters in length." )]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Please enter a password that is 6-20 characters in length.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Verifying your password is required")]
        [Compare("Password", ErrorMessage = "Oops, these passwords do not match!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Please enter a password that is 6-20 characters in length.")]
        public string VerifyPassword { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
