using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLoginDemo.Models;

namespace MVCLoginDemo.Controllers
{
    public class LoginDemoController : Controller
    {
       

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ValidateUser(ClsUserBO User)
        {
             if (ModelState.IsValid && User.UserName=="super" && User.Password=="super")
             {
                 return View("LoginSuccessfull", User);
             }
             else
             {
                 ModelState.AddModelError("", "The user name or password provided is incorrect.");
                 return View("Login",User);
             }
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}
