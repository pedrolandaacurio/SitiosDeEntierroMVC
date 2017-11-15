using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SitiosDeEntierroMVC.Startup))]
namespace SitiosDeEntierroMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
