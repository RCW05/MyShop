using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.UI.Web.Startup))]
namespace MyShop.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
