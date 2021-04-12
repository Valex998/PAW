using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PAW.Startup))]
namespace PAW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
