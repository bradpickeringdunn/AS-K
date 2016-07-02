using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASnK.Web.Startup))]
namespace ASnK.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
