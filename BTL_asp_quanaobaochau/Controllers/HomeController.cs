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
            var sp = (from p in db.SanPhams
                         select p).ToList();
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
        public ActionResult ChitietSP(string id)
        {
            ViewBag.Message = "Chi tiết sp";
            ViewBag.idsp = id;
            return View();
        }
        public ActionResult search(string key="")
        {
            ViewBag.Message = "Search";
            ViewBag.key = key;
            return View();
        }
        public ActionResult muahang(int id)
        {
            if (Session["giohang"] == null)
            {
                GioHang a = new GioHang();
                var sp = db.SanPhams.Where(s => s.MaSanPham == id).Single();
                a.Id = sp.MaSanPham;
                a.ten = sp.TenSanPham;
                a.soluong = 1;
                a.gia = Convert.ToInt32(sp.Gia);
                List<GioHang> giohang = new List<GioHang>();
                giohang.Add(a);
                Session["giohang"] = giohang;
            }
            else
            {
                List<GioHang> giohang = (List<GioHang>)Session["giohang"];
                var test = giohang.Find(s => s.Id == id);
                if (test == null)
                {
                    GioHang a = new GioHang();
                    var sp = db.SanPhams.Where(s => s.MaSanPham == id).Single();
                    a.Id = sp.MaSanPham;
                    a.ten = sp.TenSanPham;
                    a.soluong = 1;
                    a.gia = Convert.ToInt32(sp.Gia);
                    giohang.Add(a);
                }
                else
                {
                    test.soluong = test.soluong++;
                }

                Session["giohang"] = giohang;

            }
            return RedirectToRoute("nghia");
        }
    }
}