using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using HMS.Infrastructure;

namespace HMS.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string ID { get; set; }

        [Required(ErrorMessage = "User Name can't be empty")]
        [Display(Name = "User name")]
        [Remote("AlreadyRegistered", "Login")]
        public string REG_EMP_ID { get; set; }

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
        [System.ComponentModel.DataAnnotations.Compare("PASSWORD", ErrorMessage = "The password and confirmation password do not match.")]
        //[Remote("ComparePassword","Login",AdditionalFields = "PASSWORD")]        
        public string ConfirmPassword { get; set; }
    }
}