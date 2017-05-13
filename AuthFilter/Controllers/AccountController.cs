using AuthFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AuthFilter.Controllers
{
    
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult login(LoginModel model,string returnUrl)
        {
            if(FormsAuthentication.Authenticate(model.Username,model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Username, false);
                return Redirect(!string.IsNullOrEmpty(returnUrl) ? returnUrl : Url.Action("index", "home"));
            }
            else
            {
                ViewBag.Error = "Invalid creds";
                return View();

            }
        }
    }
}