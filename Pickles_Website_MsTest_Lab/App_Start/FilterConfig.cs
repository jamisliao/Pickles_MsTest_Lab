using System.Web;
using System.Web.Mvc;

namespace Pickles_Website_MsTest_Lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
