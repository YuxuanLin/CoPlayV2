using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoPlayV2.Startup))]
namespace CoPlayV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
