using System.Web;
using System.Web.Mvc;

namespace Estructura_de_Datos__Proyecto_I
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
