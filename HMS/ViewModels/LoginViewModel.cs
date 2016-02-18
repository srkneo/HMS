using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;
using System.ComponentModel.DataAnnotations;

namespace HMS.ViewModels
{
    public class LoginViewModel 
    {
        [Required]
        public string ID { get; set; }

        [Required(ErrorMessage = "User Name can't be empty")]
        [Display(Name = "User name")]
        public string EMP_ID { get; set; }

        [Required(ErrorMessage = "Password can't be empty")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PASSWORD { get; set; }

        public string USER_TYPE { get; set; }

        public string SALT { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("PASSWORD", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}