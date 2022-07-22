using System.Web;
using System.Web.Mvc;

namespace Master_TATA_Power_DDL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
