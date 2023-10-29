using System.Web;
using System.Web.Mvc;

namespace u21593681_INF272HomeworkAss3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
