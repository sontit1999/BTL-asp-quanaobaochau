﻿using BTL_asp_quanaobaochau.Models;
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
            //ViewBag.listsp = sp;
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
            //string email = Request["name"];
            //string pass = Request["pass"];
            //if (email == "levannam" && pass == "123")
            //{
            //    //ViewBag.login = "login successful!" + email + " - " + pass;
            //    return RedirectToAction("Home", "Name");
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Không đăng nhập được");
            //    //ViewBag.login = "lose!!!" + email + " - " + pass;
            //}

            return View();
        }

        public ActionResult Home()
        {
            string email = Request["name"];
            string pass = Request["pass"];
            if (email == "levannam" && pass == "123")
            {
                ViewBag.login = "login successful!" + email + " - " + pass;
                //return RedirectToAction("Home", "Name");
            }
            else
            {
                //ModelState.AddModelError("", "Không đăng nhập được");
                ViewBag.login = "lose!!!" + email + " - " + pass;
            }
            return View();
        }

        public ActionResult ThongKe()
        {
            return View();
        }
    }
}