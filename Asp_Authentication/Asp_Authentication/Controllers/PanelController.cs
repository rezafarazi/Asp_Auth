using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Asp_Authentication.Controllers
{

    //This Is Admin Panel
    [Authorize]
    public class PanelController : Controller
    {

        [Route("Panel")]
        public ActionResult Dashboard()
        {
            return Content("Welcome to Panel");
        }

    }
}