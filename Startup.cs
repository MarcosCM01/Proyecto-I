using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Estructura_de_Datos__Proyecto_I.Startup))]
namespace Estructura_de_Datos__Proyecto_I
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
