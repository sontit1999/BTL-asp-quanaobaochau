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
            var sp = (from p in db.SanPhams
                      select p).ToList();        
          
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
            if (file.ContentLength > 0)
            {
                var fileName = System.IO.Path.GetFileName(file.FileName);
                var path =Server.MapPath("~/Images/" + fileName);
                file.SaveAs(path);
                sp.LinkAnh = "Images/" + fileName;
                sp.TinhTrang = 1;
            }
            db.SanPhams.InsertOnSubmit(sp);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult deleteProduct(string id)
        {
             int idsp = Convert.ToInt32(id);
             var item = db.SanPhams.Where(m => m.MaSanPham == idsp).First();
             db.SanPhams.DeleteOnSubmit(item);
             db.SubmitChanges();
             return RedirectToAction("Index");
        
            
        }
    }
}