using BTL_asp_quanaobaochau.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class SonController : Controller
    {
        DataBaseContextDataContext db = new DataBaseContextDataContext();
        // GET: Son
        // hiển thị ds sản phẩm
        public ActionResult Index()
        {
            var sp = db.SanPhams.Where(p => p.TinhTrang == 1).OrderBy(p=>p.MaSanPham).ToList();
            sp.Reverse();
            return View(sp);
        }
        public ActionResult SearchProduct(string key)
        {
            var sp = db.SanPhams.Where(p => p.TinhTrang == 1)
                .Where(p => p.TenSanPham.Contains(key))
                .ToList();
            ViewBag.sosp = sp.Count;
            return View(sp);
        }
        public ActionResult addProduct()
        {
            var loaisp = (from lsp in db.LoaiSanPhams
                         select lsp).ToList();
            return View(loaisp);
        }
        [HttpPost]
        public ActionResult addProduct(SanPham sp,HttpPostedFileBase file)
        {
            // validate data
            if (String.IsNullOrEmpty(sp.TenSanPham))
            {
                @ViewData["tensp"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(sp.MoTa))
            {
                @ViewData["mota"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(sp.XuatXu))
            {
                @ViewData["xuatxu"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(sp.Hang))
            {
                @ViewData["hang"] = "Không được trống!";
            }
            if(file == null)
            {
                @ViewData["anh"] = "Chưa chọn ảnh!";
            }
            if (sp.Gia <= 0)
            {
                @ViewData["gia"] = "Giá phải > 0!";
            }
            if (sp.SoLuongCon <= 0)
            {
                @ViewData["soluong"] = "Số lượng > 0!";
            }
            if (String.IsNullOrEmpty(sp.TenSanPham) || String.IsNullOrEmpty(sp.MoTa) || String.IsNullOrEmpty(sp.XuatXu) || String.IsNullOrEmpty(sp.Hang) || file == null)
            {
                return this.addProduct();
            }
            else
            {
                var fileName = System.IO.Path.GetFileName(file.FileName);
                var path = Server.MapPath("~/Images/" + fileName);
                file.SaveAs(path);
                sp.LinkAnh = "Images/" + fileName;
                sp.TinhTrang = 1;
                sp.SoLuotXem = 0;
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
           
        }
        public ActionResult deleteProduct(string id)
        {
             int idsp = Convert.ToInt32(id);
             var item = db.SanPhams.Where(m => m.MaSanPham == idsp).First();
             db.SanPhams.DeleteOnSubmit(item);
             db.SubmitChanges();
             return RedirectToAction("Index");
        
            
        }
        public ActionResult editProduct(int id)
        {
           
            SanPham sp = db.SanPhams.Where(p => p.MaSanPham == id).First();
           
            var loaisp = (from lsp in db.LoaiSanPhams
                          select lsp).ToList();
            ViewBag.sanpham = sp;
            return View(loaisp);
        
        }
        [HttpPost]
        public ActionResult editProduct(SanPham sp, HttpPostedFileBase file)
        {

            // validate data
            if (String.IsNullOrEmpty(sp.TenSanPham))
            {
                @ViewData["tensp"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(sp.MoTa))
            {
                @ViewData["mota"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(sp.XuatXu))
            {
                @ViewData["xuatxu"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(sp.Hang))
            {
                @ViewData["hang"] = "Không được trống!";
            }
           
            if (sp.Gia <= 0)
            {
                @ViewData["gia"] = "Giá phải > 0!";
            }
            if (sp.SoLuongCon <= 0)
            {
                @ViewData["soluong"] = "Số lượng > 0!";
            }
            if (String.IsNullOrEmpty(sp.TenSanPham) || String.IsNullOrEmpty(sp.MoTa) || String.IsNullOrEmpty(sp.XuatXu) || String.IsNullOrEmpty(sp.Hang) || sp.Gia <= 0 || sp.SoLuongCon <=0)
            {
                return this.editProduct(sp.MaSanPham);
            }
            else
            {
                // lấy sp ngta đang sửa trong csdl
                var spcansua = db.SanPhams.Where(p => p.MaSanPham == sp.MaSanPham).First();
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = System.IO.Path.GetFileName(file.FileName);
                    var path = Server.MapPath("~/Images/" + fileName);
                    file.SaveAs(path);
                    spcansua.LinkAnh = "Images/" + fileName;
                }
                spcansua.TenSanPham = sp.TenSanPham;
                spcansua.MoTa = sp.MoTa;
                spcansua.Gia = sp.Gia;
                spcansua.SoLuongCon = sp.SoLuongCon;
                spcansua.SoLuotXem = sp.SoLuotXem;
                spcansua.XuatXu = sp.XuatXu;
                spcansua.Hang = sp.Hang;
                spcansua.MaLoaiSanPham = sp.MaLoaiSanPham;
                sp.TinhTrang = sp.TinhTrang;
                UpdateModel(spcansua);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }

            
        }
        public ActionResult ViewDetailsProduct(int id)
        {
            var sp = db.SanPhams.Where(p => p.MaSanPham == id).First();
            ViewBag.sp = sp;
            return View();
        }

    }
}