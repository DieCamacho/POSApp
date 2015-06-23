using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POSApp.Startup))]
namespace POSApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
