using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: LoginAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult home()
        {
            string email = Request["name"];
            string pass = Request["pass"];
            if (email == "levannam" && pass == "123")
            {
                ViewBag.login = "login successful!" + email + " - " + pass;
            }
            else
            {
                ViewBag.login = "lose!!!" + email + " - " + pass;
            }

            return View();
        }
    }
}