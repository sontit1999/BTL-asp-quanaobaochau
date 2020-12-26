using BTL_asp_quanaobaochau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau.Controllers
{
    public class QuyenController : Controller
    {
        DataBaseContextDataContext db = new DataBaseContextDataContext();

        // GET: Quyen
        // trang index hiển thị ds tin tức
        public ActionResult Index()
        {
            DateTime d = DateTime.Now;
            d = d.AddMonths(-1);
            ViewBag.time = d;
            var tin = db.TinTucs.OrderBy(p => p.MaTinTuc).ToList();
            tin.Reverse();
            return View(tin);
        }
        public ActionResult Quanlytin()
        {
            var tin = db.TinTucs.OrderBy(p => p.MaTinTuc).ToList();
            tin.Reverse();
            return View(tin);
        }
        // trang Detail neww hiển thị chi tiết tin tức
        public ActionResult DetailsNew(int id)
        {
            var tin = db.TinTucs.Where(p => p.MaTinTuc == id).First();
            ViewBag.tin = tin;
            return View();
        }
        public ActionResult AddNews()
        {
            var tin = (from tintuc in db.TinTucs select tintuc).ToList();
            return View(tin);

        }
        [HttpPost]
        public ActionResult AddNews(TinTuc tin, HttpPostedFileBase file)
        {
            if (String.IsNullOrEmpty(tin.TieuDe))
            {
                @ViewData["tieude"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(tin.NoiDung))
            {
                @ViewData["noidung"] = "Không được trống!";
            }
            if (file == null)
            {
                @ViewData["anh"] = "Chưa chọn ảnh!";
            }

            if (String.IsNullOrEmpty(tin.NoiDung) || String.IsNullOrEmpty(tin.TieuDe) || file == null)
            {
                return this.AddNews();
            }
            else
            {
                var fileName = System.IO.Path.GetFileName(file.FileName);
                var path = Server.MapPath("~/Images/" + fileName);
                file.SaveAs(path);
                tin.LinkAnh = "Images/" + fileName;
                db.TinTucs.InsertOnSubmit(tin);
                db.SubmitChanges();
                return RedirectToAction("Quanlytin");
            }


        }
        public ActionResult deleteNews(string id)
        {
            int idnews = Convert.ToInt32(id);
            var item = db.TinTucs.Where(m => m.MaTinTuc == idnews).First();
            db.TinTucs.DeleteOnSubmit(item);
            db.SubmitChanges();
            return RedirectToAction("Quanlytin");


        }
        public ActionResult EditNews(int id)
        {
            var tin = db.TinTucs.Where(t => t.MaTinTuc == id).First();
            return View(tin);

        }
        [HttpPost]
        public ActionResult EditNews(TinTuc tin, HttpPostedFileBase file)
        {
            if (String.IsNullOrEmpty(tin.TieuDe))
            {
                @ViewData["tieude"] = "Không được trống!";
            }
            if (String.IsNullOrEmpty(tin.NoiDung))
            {
                @ViewData["noidung"] = "Không được trống!";
            }
            if (file == null)
            {
                @ViewData["anh"] = "Chưa chọn ảnh!";
            }

            if (String.IsNullOrEmpty(tin.NoiDung) || String.IsNullOrEmpty(tin.TieuDe))
            {
                return this.EditNews(tin.MaTinTuc);
            }
            else
            {
                var tincansua = db.TinTucs.Where(p => p.MaTinTuc == tin.MaTinTuc).First();
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = System.IO.Path.GetFileName(file.FileName);
                    var path = Server.MapPath("~/Images/" + fileName);
                    file.SaveAs(path);
                    tincansua.LinkAnh = "Images/" + fileName;
                }
                tincansua.TieuDe = tin.TieuDe;
                tincansua.NoiDung = tin.NoiDung;

                UpdateModel(tincansua);
                db.SubmitChanges();
                return RedirectToAction("Quanlytin");
            }


        }
    }
}