using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LondonSights.Startup))]
namespace LondonSights
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
