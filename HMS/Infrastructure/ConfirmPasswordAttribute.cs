using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using HMS.ViewModels;

namespace HMS.Infrastructure
{
    public class ConfirmPasswordAttribute : ValidationAttribute
    {
        public ConfirmPasswordAttribute()
        {
            ErrorMessage = "The password and confirmation password do not match.";
        }

        public override bool IsValid(object value)
        {
            RegisterViewModel rvm = value as RegisterViewModel;

            if(rvm == null || string.IsNullOrEmpty(rvm.ConfirmPassword) || string.IsNullOrEmpty(rvm.PASSWORD) || rvm.PASSWORD == rvm.ConfirmPassword)
            {
                return true;
            }
            else
            {
                return !(rvm.PASSWORD != rvm.ConfirmPassword);
            }
            
        }
    }
}