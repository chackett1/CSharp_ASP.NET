using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaPalace.Startup))]
namespace PizzaPalace
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
