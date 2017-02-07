using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Countries.Web.Startup))]
namespace Countries.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}