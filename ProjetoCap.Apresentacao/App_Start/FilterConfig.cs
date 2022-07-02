using System.Web.Mvc;

namespace ProjetoCap.Apresentacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public class HandleAndLogErrorAttribute: HandleErrorAttribute
        {
             
        }
    }
}
