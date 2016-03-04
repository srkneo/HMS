using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;
using System.Web.Mvc;
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
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PASSWORD { get; set; }

        public string ROLE { get; set; }

        public string SALT { get; set; }

    }
}