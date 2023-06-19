using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisheriesAgency.Model
{
    public class ValidationModel
    {
        [Required(ErrorMessage = "Please enter your username.")]
        [StringLength(24, MinimumLength = 4, ErrorMessage = "Username must be between 4 and 24 characters.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [StringLength(24, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 24 characters.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please enter your confirm password.")]
        [Compare("Password", ErrorMessage = "Your password and confirm password must be the same.")]
        public string? ConfirmPassword { get; set; }
    }
}
