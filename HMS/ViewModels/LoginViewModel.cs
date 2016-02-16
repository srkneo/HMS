using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;
using System.ComponentModel.DataAnnotations;namespace HMS.ViewModels
{
    public class LoginViewModel 
    {
        [Required]
        public string ID { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string EMP_ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PASSWORD { get; set; }

        public string USER_TYPE { get; set; }

        public string SALT { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}