using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GadgetCity.Startup))]
namespace GadgetCity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
