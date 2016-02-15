using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public partial class User
    {
        class LoginUserData
        {
            [Required(ErrorMessage = "Employee Id is Required")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Password is Required")]
            public string Password { get; set; }
        }
    }
}