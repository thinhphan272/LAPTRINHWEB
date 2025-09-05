using System.Web;
using System.Web.Mvc;

namespace LTWeb02_Bai2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}