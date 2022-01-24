using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hibrid.Startup))]
namespace Hibrid
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
