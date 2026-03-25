using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drivers_Club.Startup))]
namespace Drivers_Club
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
