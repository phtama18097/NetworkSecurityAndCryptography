using System.Web;
using System.Web.Mvc;

namespace A18097_PhamHoangTam_Cryptography
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
