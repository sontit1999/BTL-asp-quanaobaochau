using BTL_asp_quanaobaochau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class NghiaController : Controller
    {
        DataBaseContextDataContext db = new DataBaseContextDataContext();
        // GET: Nghia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NhapThongTinDatHang()
        {
            return View();
        }
        public ActionResult muahang(int id)
        {
            if (Session["giohang"] == null)
            {
                try
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
                    ViewBag.listsp = giohang;
                }
                catch (InvalidOperationException)
                {
                    ViewBag.listsp = null;
                }
                
            }
            else
            {
                List<GioHang> giohang = (List<GioHang>)Session["giohang"];
                var index = giohang.FindIndex(sp => sp.Id == id);
                if (index == -1)
                {
                    try
                    {
                        ViewBag.kiemtra = "null";
                        GioHang a = new GioHang();
                        var sp = db.SanPhams.Where(s => s.MaSanPham == id).Single();
                        a.Id = sp.MaSanPham;
                        a.ten = sp.TenSanPham;
                        a.soluong = 1;
                        a.gia = Convert.ToInt32(sp.Gia);
                        giohang.Add(a);
                    }catch(InvalidOperationException)
                    {
                        
                    }
                }
                else
                {
                    giohang[index].soluong++;
                }
                Session["giohang"] = giohang;
                ViewBag.length = giohang.Count;
                ViewBag.listsp = giohang;
            }
            return View();
        }
        
    }
}