using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Security;
using System.Web.Security;

namespace Asp_Authentication.Controllers
{

    //Website Controller For Example Login And Signup

    public class HomeController : Controller
    {



        //Login Route Start
        [Route("Login")]
        public ActionResult Login()
        {
            return View("Login");
        }
        //Login Route End



        //Login Event Start
        [ValidateAntiForgeryToken]
        [HttpPost]
        [Route("Login")]
        public void Login(string login_username)
        {
            using (Asp_Authentication.First_DBEntities DB = new First_DBEntities())
            {
                var user = from users in DB.users where users.name.Equals(login_username) || users.family.Equals(login_username) select users;
                if(user.Count()>0)
                {
                    FormsAuthentication.SetAuthCookie(login_username, false);
                    Response.Redirect("~/Panel");
                }
                else
                {
                    Response.Redirect("~/Login");
                }
            }
        }
        //Login Event End



    }
}