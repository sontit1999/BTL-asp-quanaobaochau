using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   
            // comment test to Lê nam
            ViewBag.online = 123;
            ViewBag.totalvisit = 456789;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DatHang()
        {
            ViewBag.Message = " Đặt Hàng";
            return View();
        }
    }
}