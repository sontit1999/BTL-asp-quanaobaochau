using BTL_asp_quanaobaochau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class NamController : Controller
    {
        DataBaseContextDataContext data = new DataBaseContextDataContext();
        // GET: Nam
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SanPham(int id)
        {
            var sp = data.SanPhams.Where(m => m.MaLoaiSanPham == id);
            ViewBag.listsp = sp;
            return View();
        }

        public ActionResult ChiTietSanPham(int id)
        {
            var sp = data.SanPhams.Where(m => m.MaSanPham == id).First();
            var sp2 = (from p in data.SanPhams
                      where p.MaLoaiSanPham == 1 || p.MaLoaiSanPham == 2 || p.MaLoaiSanPham == 3 || p.MaLoaiSanPham == 4 || p.MaLoaiSanPham == 5
                      select p).ToList();
            ViewBag.listsp = sp2;
            var img = (from p in data.HinhAnhs
                       where p.MaSanPham == id
                       select p).ToList();
            ViewBag.listimg = img;

            return View(sp);
        }

        public ActionResult QuanAoBeTrai()
        {
            var sp = (from p in data.SanPhams
                      where p.MaLoaiSanPham == 1 || p.MaLoaiSanPham == 2 || p.MaLoaiSanPham == 3 || p.MaLoaiSanPham == 4 || p.MaLoaiSanPham == 5
                      select p).ToList();
            ViewBag.listsp = sp;
            return View();
        }

        public ActionResult ThoiTrangBeGai()
        {
            var sp = (from p in data.SanPhams
                      where p.MaLoaiSanPham == 6 || p.MaLoaiSanPham == 7 || p.MaLoaiSanPham == 8 || p.MaLoaiSanPham == 9 || p.MaLoaiSanPham == 10
                      select p).ToList();
            ViewBag.listsp = sp;
            return View();
        }

        public ActionResult Login()
        {          
            return View();
        }
       
        [HttpPost]
        public ActionResult Login(string name, string pass)
        {
          
            if (name.Equals("admin") && pass.Equals("123"))
            {
                return RedirectToAction( "Index", "Son");
            }
            else
            {
                ViewData["login"] = "login fall !!!";
                return this.Login();
            }  
        }

        public ActionResult ThongKe()
        {

            // biểu đồ cột
            var DoanhThuNgay = (from p in data.DonHangs select p.TongTien).ToList();
            var DoanhThuThang9 = from p in data.DonHangs  where p.NgayDat.Value.Month == 9 select p.TongTien;
            var DoanhThuThang10 = from p in data.DonHangs where p.NgayDat.Value.Month == 10 select p.TongTien;
            var DoanhThuThang11 = from p in data.DonHangs where p.NgayDat.Value.Month == 11 select p.TongTien;
            var DoanhThuThang12 = from p in data.DonHangs where p.NgayDat.Value.Month == 12 select p.TongTien;     

            double ngay =Convert.ToInt32(DoanhThuNgay.Sum());
            double thang9= Convert.ToInt32(DoanhThuThang9.Sum());
            double thang10 = Convert.ToInt32(DoanhThuThang10.Sum());
            double thang11 = Convert.ToInt32(DoanhThuThang11.Sum());
            double thang12 = Convert.ToInt32(DoanhThuThang12.Sum());

            ViewBag.ngay = ngay;
            ViewBag.thang9 = thang9;
            ViewBag.thang10 = thang10;
            ViewBag.thang11 = thang11;
            ViewBag.thang12 = thang12;

            // Tìm sp bán chạy nhất
            var groupSL =
                from sp in data.ChiTietDonHangs
                group sp by sp.MaSanPham into spGroup
                select new
                {
                    msp = spGroup.Key,
                    SL = spGroup.Sum(x => x.SoLuongMua),
                };
            var DTmax = groupSL.OrderByDescending(m => m.SL).First();
            int msp = Convert.ToInt32(DTmax.msp);
            int soLuong = Convert.ToInt32(DTmax.SL);
            ViewBag.masp = msp;
            ViewBag.sl = soLuong;

            //Tìm đơn hàng có gia trị cao nhất
            var DoanhThuMax2 = data.DonHangs.OrderByDescending(m => m.TongTien).First();
            int tongDoanhThu = Convert.ToInt32(DoanhThuMax2.TongTien);
            int maDonHang = Convert.ToInt32(DoanhThuMax2.MaDonHang);
            ViewBag.tongDT = tongDoanhThu;
            ViewBag.maDH = maDonHang;

            //tìm doanh thu 1 ngày
            var groupDT =
                from sp in data.DonHangs
                group sp by sp.NgayDat into spGroup
                select new
                {
                    key = spGroup.Key,
                    tongTien = spGroup.Sum(x => x.TongTien),
                };
            var TONG = groupDT.OrderByDescending(m => m.tongTien).First();
            int TTien = Convert.ToInt32(TONG.tongTien);
            string topNgay = Convert.ToDateTime(TONG.key).ToString("d");
            ViewBag.TopNgay = topNgay;
            ViewBag.TongDT = TTien;

            return View();
        }
        [HttpPost]
        public ActionResult ThongKe(string dateT)
        {
            ViewBag.date = dateT;

            var donHang_ngay = from x in data.DonHangs
                               where x.NgayDat.Value.Day == Convert.ToDateTime(dateT).Day
                                   && x.NgayDat.Value.Month == Convert.ToDateTime(dateT).Month
                                   && x.NgayDat.Value.Year == Convert.ToDateTime(dateT).Year
                               select x;

            var result = from p in donHang_ngay
                         from c in data.ChiTietDonHangs
                         where p.MaDonHang == c.MaDonHang
                         select new
                         {
                             masp = c.MaSanPham,
                             tongTien = p.TongTien
                         };
            var result2 = from p in result
                          from c in data.SanPhams
                          where p.masp == c.MaSanPham
                          select new
                          {
                              mlsp = c.MaLoaiSanPham,
                              tongTien2 = p.tongTien
                          };

            var lsp1= result2.Where(m => m.mlsp == 1).FirstOrDefault();
            var lsp2 = result2.Where(m => m.mlsp == 2).FirstOrDefault();
            var lsp3 = result2.Where(m => m.mlsp == 3).FirstOrDefault();
            var lsp4 = result2.Where(m => m.mlsp == 4).FirstOrDefault();
            var lsp5 = result2.Where(m => m.mlsp == 5).FirstOrDefault();
            var lsp6 = result2.Where(m => m.mlsp == 6).FirstOrDefault();
            var lsp7 = result2.Where(m => m.mlsp == 7).FirstOrDefault();
            var lsp8 = result2.Where(m => m.mlsp == 8).FirstOrDefault();
            var lsp9 = result2.Where(m => m.mlsp == 9).FirstOrDefault();
            var lsp10 = result2.Where(m => m.mlsp == 10).FirstOrDefault();
            var lsp11 = result2.Where(m => m.mlsp == 11).FirstOrDefault();
            var lsp12 = result2.Where(m => m.mlsp == 12).FirstOrDefault();
            int tsp1, tsp2, tsp3, tsp4, tsp5, tsp6, tsp7, tsp8, tsp9, tsp10, tsp11, tsp12;
            string tdefault;

            if (lsp1== null)
            {
                tsp1 = 1;
            } else
            {
                tsp1 = Convert.ToInt32(lsp1.tongTien2);
            }

            if (lsp2 == null)
            {
                tsp2 = 1;
            }
            else
            {
                tsp2 = Convert.ToInt32(lsp2.tongTien2);
            }

            if (lsp3 == null)
            {
                tsp3 = 1;
            }
            else
            {
                tsp3 = Convert.ToInt32(lsp3.tongTien2);
            }

            if (lsp4 == null)
            {
                tsp4 = 1;
            }
            else
            {
                tsp4 = Convert.ToInt32(lsp4.tongTien2);
            }

            if (lsp5 == null)
            {
                tsp5 = 1;
            }
            else
            {
                tsp5 = Convert.ToInt32(lsp5.tongTien2);
            }

            if (lsp6 == null)
            {
                tsp6 = 1;
            }
            else
            {
                tsp6 = Convert.ToInt32(lsp6.tongTien2);
            }

            if (lsp7 == null)
            {
                tsp7 = 1;
            }
            else
            {
                tsp7 = Convert.ToInt32(lsp7.tongTien2);
            }

            if (lsp8 == null)
            {
                tsp8 = 1;
            }
            else
            {
                tsp8 = Convert.ToInt32(lsp8.tongTien2);
            }

            if (lsp9 == null)
            {
                tsp9 = 1;
            }
            else
            {
                tsp9 = Convert.ToInt32(lsp9.tongTien2);
            }

            if (lsp10 == null)
            {
                tsp10 = 1;
            }
            else
            {
                tsp10 = Convert.ToInt32(lsp10.tongTien2);
            }

            if (lsp11 == null)
            {
                tsp11 = 1;
            }
            else
            {
                tsp11 = Convert.ToInt32(lsp11.tongTien2);
            }

            if (lsp12 == null)
            {
                tsp12 = 1;
            }
            else
            {
                tsp12 = Convert.ToInt32(lsp12.tongTien2);
            }

            if(tsp1 == 1 && tsp2 == 1 && tsp3 == 1 && tsp4 == 1 && tsp5 == 1 && tsp6 == 1 && tsp7 == 1 && tsp8 == 1 && tsp9 == 1 && tsp10 == 1 && tsp11 == 1 && tsp12 == 1)
            {
                tdefault = "Default";
            } else
            {
                tdefault = "ON";
            }

            ViewBag.lsp1 = tsp1;
            ViewBag.lsp2 = tsp2;
            ViewBag.lsp3 = tsp3;
            ViewBag.lsp4 = tsp4;
            ViewBag.lsp5 = tsp5;
            ViewBag.lsp6 = tsp6;
            ViewBag.lsp7 = tsp7;
            ViewBag.lsp8 = tsp8;
            ViewBag.lsp9 = tsp9;
            ViewBag.lsp10 = tsp10;
            ViewBag.lsp11 = tsp11;
            ViewBag.lsp12 = tsp12;
            ViewBag.deFault = tdefault;

            return this.ThongKe();
        }
    }
}