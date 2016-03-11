using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.Web.Mvc;

namespace HMS.Infrastructure
{
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        public string LoginPage { get; set; }
        public string Role { get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //Send the Return url to login page

            LoginPage += "?ReturnUrl=" + filterContext.HttpContext.Request.RawUrl;

            if(!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect(LoginPage);
            }
            else
            {
                if(Role != null)
                {
                    if(!filterContext.HttpContext.User.IsInRole(Role))
                    {
                        filterContext.HttpContext.Response.Redirect(LoginPage);
                    }
                }
            }

            base.OnAuthorization(filterContext);
        }
    }
}