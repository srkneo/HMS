using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;
using System.ComponentModel.DataAnnotations;namespace HMS.ViewModels
{
    public class LoginViewModel : USER
    {
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}