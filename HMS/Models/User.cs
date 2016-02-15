using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    [MetadataType(typeof(RegisterModel))]
    public class RegisterModel
    {
        
            [Required(ErrorMessage = "Employee Id is Required")]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            
            [Required(ErrorMessage = "Password is Required")]
            [StringLength(100,ErrorMessage = "Password must be atleast {0} character long",MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("Password",ErrorMessage = "The Password and Confirm password do not match")]
            public string ComfirmPassword { get; set; }
        
    }
}