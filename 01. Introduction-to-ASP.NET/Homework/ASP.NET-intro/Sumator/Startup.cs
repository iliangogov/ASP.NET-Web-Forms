using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sumator.Startup))]
namespace Sumator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
