using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.ViewModels;
using HMS.Models;
using System.Security.Cryptography;
using System.Web.Security;

namespace HMS.Infrastructure
{
    public class Login
    {
        public string getEmpId(string user)
        {
            try
            {
                string emp_id = user;

                using (var context = new HMSDBEntities())
                {
                        var empid = from u in context.USERs
                                where u.EMP_ID == emp_id
                                select u;

                    if (empid.ToList().Count == 1)
                    {
                        return emp_id.ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {                
                throw ex;
            }            
        }

        public bool registerEmployee(RegisterViewModel user)
        {
            try
            {
                user.SALT = CreateSalt();
                user.ID = Guid.NewGuid().ToString();
                user.PASSWORD = CreatePasswordHash(user.PASSWORD, user.SALT);
                user.ROLE = "SA";

                USER objUser = new USER
                {
                    ID = user.ID,
                    EMP_ID = user.REG_EMP_ID,
                    PASSWORD = user.PASSWORD,
                    ROLE = user.ROLE,
                    SALT = user.SALT,
                };

                using (var context = new HMSDBEntities())
                {
                    context.USERs.Add(objUser);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public  string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] byteArr = new byte[64];
            rng.GetBytes(byteArr);

            return Convert.ToBase64String(byteArr);
        }

        public  string CreatePasswordHash(string password, string salt)
        {
            string passwordSalt = String.Concat(password, salt);
            string hashedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(passwordSalt, "sha1");
            return hashedPwd;
        }
    }
}