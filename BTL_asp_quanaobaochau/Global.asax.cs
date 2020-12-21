using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BTL_asp_quanaobaochau
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // đọc file sl.txt chứa tổng số ng đã truy cập và gán cho biến tottal user
            Application.Lock();
            System.IO.StreamReader sr = new System.IO.StreamReader(Server.MapPath("SL.txt"));
            string numberTotal = sr.ReadLine();
            sr.Close();
            Application.UnLock();
            Application["Totaluser"] = numberTotal;
           
            Application["usernow"] = 0;
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start()
        {
            /*Application.Lock();
            Application["Totaluser"] = int.Parse(Application["Totaluser"].ToString()) + 1 ;
            Application["usernow"] = int.Parse(Application["usernow"].ToString()) + 1;
         
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("SL.txt"));
            sw.Write(Application["Totaluser"].ToString());
            sw.Close();
            Application.UnLock();*/
        }
        protected void Session_End()
        {
            Application.Lock();
            Application["Totaluser"] = int.Parse(Application["Totaluser"].ToString()) + 1;
            Application["usernow"] = int.Parse(Application["usernow"].ToString()) - 1;
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("SL.txt"));
            sw.Write(Application["Totaluser"].ToString());
            sw.Close();
            Application.UnLock();
        }
    }
}
