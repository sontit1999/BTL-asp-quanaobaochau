using System.Web;
using System.Web.Mvc;

namespace BTL_asp_quanaobaochau
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
