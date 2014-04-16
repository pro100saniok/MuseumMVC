using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Museum.Web.Startup))]
namespace Museum.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
