using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VizAir.Startup))]
namespace VizAir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
