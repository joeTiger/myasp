using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myasp.Startup))]
namespace myasp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
