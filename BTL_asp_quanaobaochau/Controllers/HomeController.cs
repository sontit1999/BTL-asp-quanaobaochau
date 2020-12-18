using BTL_asp_quanaobaochau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class HomeController : Controller
    {
        DataBaseContextDataContext db = new DataBaseContextDataContext();
        public ActionResult Index()
        {
            var sp = db.SanPhams.ToList();
            // comment test to Lê nam
            var listNew = (from tt in db.TinTucs
                           select tt).ToList();
            ViewBag.online = 123;
            ViewBag.totalvisit = 456789;
            ViewBag.listsp = sp;
            ViewBag.listtt = listNew;
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
        public ActionResult ChitietSP(int id)
        {
            ViewBag.Message = "Chi tiết sp";
            ViewBag.sp = db.SanPhams.Where(p => p.MaSanPham == id).First();
            return View();
        }
        public ActionResult search(string key="")
        {
            ViewBag.Message = "Search";
            ViewBag.listsp = db.SanPhams.Where(p => p.TenSanPham.Contains(key));
            return View();
        }
        public ActionResult ChitietTT(int id)
        {
            ViewBag.Message = "Chi tiết tin";
            ViewBag.tt = db.TinTucs.Where(p => p.MaTinTuc == id).First();
            return View();
        }
    }
}